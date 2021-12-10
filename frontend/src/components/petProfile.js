import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import medicalRecord from "./medicalRecord";
import petProfile from "../components/petProfile";
import pets from "../components/pets";
import weight from "../components/weight";

export default {
    PetDetails,
    SetupMedicalPageButton,
    SetupCreatePet,
    CreatePet,
    EditPet,
    SetupUpdateMedicalRecord,
    SetupCreatePetForm,
    SetupWeightTrackerLink
}

function PetDetails(pet) {
    
    return `
    <div id="details">
    <ul>
    <li>Name: ${pet.name}</li>
    <li>Age: ${pet.age}</li>
    <li>Species: ${pet.species}</li>
    <li>Breed: ${pet.breed}</li>
    <li>Gender: ${pet.gender}</li>
    <li id="currentPetId">${pet.id}</li>
    </ul>
    <div id="divMedicalInfo"></div>
    <div id="divWeightPage"></div>
    <button class="btn btn-primary" id="btnMedicalPage">Medical Record</button>
    <button class="btn btn-primary btnWeightPage" id = "weightTrackerBtn">Weight Tracker</button>
    </div>
    <div id="medicalRecord">
    <h2>Provider Information</h2>
    <ol>
    <li>Primary Vet: ${pet.medicalRecord.primaryVet}</li>
    <li>Clinic: ${pet.medicalRecord.clinic}</li>
    <li>Phone: ${pet.medicalRecord.phone}</li>
    <li>Address: ${pet.medicalRecord.street + " " + pet.medicalRecord.city + " " + pet.medicalRecord.state + " " + pet.medicalRecord.zip}</li>
    </ol>
    <button class="btn btn-primary" id="btnUpdateMedicalRecord">Update</button>
    </div>
    `
    // /*<div id="medicalItems">
    // ${pet.medicalRecord.medicalItems.foreach(item => {
    //     return `
    //         ${item.description}

    //     `
    // })

    // }
    // </div>
}

function SetupCreatePetForm() {
    return `
    <div id="createPet">
    <form>
    <label>Pet Name</label>
        <input type="text" id="PetName"><br><br>
        <label>Pet Age</label>
        <input type="text" id="PetAge"><br><br>
        <label>Pet Species</label>
        <input type="text" id="PetSpecies"><br><br>
        <label>Pet Breed</label>
        <input type="text" id="PetBreed"><br><br>
        <label>Pet Gender</label>
        <input type="text" id="PetGender"><br><br>
        <input type="button" class="btn btn-primary" id="btnSubmitPet" value="submit">
    </form>
    </div>
    `
}

function SetupCreatePet() {
    const btnSubmitPet = document.getElementById("btnSubmitPet");
    btnSubmitPet.addEventListener("click", function(){
        console.log("check add pet button");
        const newPet = {
            Id: 0,
            Name: document.getElementById("PetName").value,
            Age: document.getElementById("PetAge").value,
            Species: document.getElementById("PetSpecies").value,
            Breed: document.getElementById("PetBreed").value,
            Gender: document.getElementById("PetGender").value,
            OwnerId: 1
            // upload picture?
        }
        CreatePet(newPet);
    });
}

// async function CreatePetOLD(newPet){
//         console.log("added new pet");
//         let pet = await apiActions.postRequest(CONSTANTS.PetAPIURL, newPet, data => {
//             return data;
//             //CreateMedicalRecord(newPet);
//     });
//     console.log(pet);
// }

async function CreatePet(newPet) {
    let pet = await fetch(CONSTANTS.PetAPIURL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(newPet)
    })
    .then(response => response.json())
    
    let petId = pet.id;

    let newRecord = {
        Id: 0,
        Clinic: "",
        PrimaryVet: "",
        Phone: "",
        Street: "",
        City: "",
        State: "",
        Zip: "",
        PetId: petId
    }

    let medicalRecord = await fetch(CONSTANTS.MedicalRecordAPIURL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(newRecord)
    })
    .then(response => response.json())
    console.log(medicalRecord);
    
    apiActions.getRequest(CONSTANTS.PetAPIURL + petId, data => {
        CONSTANTS.content.innerHTML = PetDetails(data);
        SetupMedicalPageButton(data);
        SetupUpdateMedicalRecord(data);
    });
}

// function SetupPetProfileEventListeners(){
//     //SetupEditPetButton();
//     //SetupDeletePetButton();
//     SetupMedicalPageButton();
//     SetupUpdateMedicalRecord();

// }

// function SetupDeletePetButton(){

// }

function EditPet(pet) {
    console.log('edit pet button');
    return `
        <input type="text" value="${pet.name}" id="PetName" />
        <input type="text" value="${pet.age}" id="PetAge" />
        <input type="text" value="${pet.species}" id="PetSpecies" />
        <input type="text" value="${pet.breed}" id="PetBreed" />
        <input type="text" value="${pet.gender}" id="PetGender" />
        <button id="btnSaveUpdatePet">Save</button>
    `;
}


export function SetupEditPetButton(pet) {
    let btnEditPet = document.getElementById("btnEditPet");
    btnEditPet.addEventListener("click", function () {
        CONSTANTS.content.innerHTML = EditPet(pet);
    });
}

function SetupUpdateMedicalRecord(data) {
    let updateMedicalRecord = document.getElementById("btnUpdateMedicalRecord");


        updateMedicalRecord.addEventListener("click", function() {
            console.log(data);
            CONSTANTS.content.innerHTML = medicalRecord.UpdateMedicalRecord(data);
            medicalRecord.SetupMedicalRecordSaveButton();
        });
};


function SetupMedicalPageButton(data) {
    let medicalLink = document.getElementById("btnMedicalPage");

        medicalLink.addEventListener("click", function() {
            console.log("medical page button clicked");

                CONSTANTS.content.innerHTML = medicalRecord.MedicalDetails(data);
                //SetupUpdateMedicalRecord();
                medicalRecord.setupMedicalItemLinks();
                medicalRecord.SetupCreateNewMedicalItem();      
        });
};

function SetupWeightTrackerLink(){
    let weightTrackerLink = document.getElementById("weightTrackerBtn");
    console.log("setting up weight tracker link");
    let petId = document.getElementById('currentPetId');
    weightTrackerLink.addEventListener("click", function(){
        CONSTANTS.content.innerHTML = weight.SetupWeightForm(petId);
        weight.SetupCreateWeight();
    })
}
