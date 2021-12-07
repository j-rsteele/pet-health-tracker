import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import medicalRecord from "./medicalRecord";
import pets from "../components/pets";

export default {
    PetDetails,
    SetupMedicalPageLink,
    SetupCreatePet,
    CreatePet,
    EditPet,
    SetupCreatePetForm
}

function PetDetails(pet) {
    return `
    <div id="details">
    <ul>
    <li>${pet.photo}</li>
    <li>Name: ${pet.name}</li>
    <li>Age: ${pet.age}</li>
    <li>Species: ${pet.species}</li>
    <li>Breed: ${pet.breed}</li>
    <li>Gender: ${pet.gender}</li>
    </ul>
    <div id="divMedicalInfo"></div>
    <div id="divWeightPage"></div>
    <button class="btn btn-primary btnMedicalPage">Medical Record</button>
    <button class="btn btn-primary btnWeightPage">Weight Tracker</button>
    <button class="btn btn-primary btnAppointmentsPage">Appointments</button>
    </div>
    <div id="medicalRecord">
    <ol>
    <li>Primary Vet: ${pet.medicalRecord.primaryVet}</li>
    <li>Clinic: ${pet.medicalRecord.clinic}</li>
    <li>Phone: ${pet.medicalRecord.phone}</li>
    <li>Address: ${pet.medicalRecord.street + " " + pet.medicalRecord.city + " " + pet.medicalRecord.state + " " + pet.medicalRecord.zip}</li>
    </ol>
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
        <input type="text" id="PetGender">
        <input type="button" id="btnSubmitPet" value="submit">
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

async function CreatePetOLD(newPet){
        console.log("added new pet");
        let pet = await apiActions.postRequest(CONSTANTS.PetAPIURL, newPet, data => {
            return data;
            //CreateMedicalRecord(newPet);
    });
    console.log(pet);
}

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
    
    pet.medicalRecord = medicalRecord;
    CONSTANTS.content.innerHTML = PetDetails(pet);
}

function EditPet(pet) {
    console.log('edit pet button');
    return `
        <input type="text" value="${pet.name}" id="PetName" />
        <input type="text" value="${owner.age}" id="PetAge" />
        <input type="text" value="${owner.species}" id="PetSpecies" />
        <input type="text" value="${owner.breed}" id="PetBreed" />
        <input type="text" value="${owner.gender}" id="PetGender" />
        <button id="btnSaveOwner">Update</button>
    `;
}


export function SetupEditPetButton(pet) {
    let btnEditPet = document.getElementById("btnEditPet");
    btnEditPet.addEventListener("click", function () {
        CONSTANTS.content.innerHTML = EditPet(pet);
        SetupSaveOwnerButton();
    });
}

// function CreatePet() {
//     const btnAddPet = document.getElementById("btnAddPet");
//     btnAddPet.addEventListener("click", function (){
//         const newPet = {
//             Name: document.getElementById("PetName").value,
//             Age: document.getElementById("PetAge").value,
//             Species: document.getElementById("PetSpecies").value,
//             Breed: document.getElementById("PetBreed").value,
//             Gender: document.getElementById("PetGender").value
//             // upload picture?
//         }

//         apiActions.postRequest("https://localhost:44313/api/albums/", newAlbum, data => {

//             pageContent.innerHTML = Pet.DisplayPet(data);
//             Album.SetupEditButton();
          
//         });
//     });
// }



function SetupMedicalPageLink() {
    let medicalLink = document.querySelectorAll(".btnMedicalPage");

        medicalLink.addEventListener("click", function() {

            // let petId = this.nextElementSibling.value;
            // console.log("Pet Id:" + petId);

            apiActions.getRequest(CONSTANTS.MedicalRecordAPIURL + petId, data => {
                CONSTANTS.content.innerHTML = medicalRecord.MedicalDetails(data);
            });
        });
};