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
    // /*<div id="medicalItems">
    // ${pet.medicalRecord.medicalItems.foreach(item => {
    //     return `
    //         ${item.description}

    //     `
    // })

    // }
    // </div>
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
        CONSTANTS.content.innerHTML = pets.DisplayAllPets(data);
    });
}

function CreatePet(newPet){
        console.log("added new pet");
        apiActions.postRequest(CONSTANTS.PetAPIURL, newPet, data => {
            CONSTANTS.title.innerText = "";
            console.log(data);
            //CreateMedicalRecord(newPet);
    });
}

async function CreateMedicalRecord(newPet){
    let petId = 0;
    await apiActions.getRequestASYNC(`https://localhost:44322/api/Owner/${newPet.OwnerId}/${newPet.Name}`, function(){
        console.log(data);
        petId = data.Id
    });
    console.log(petId);
    let medicalRecord = {
        Id: 0,
        PetId: petId
    }
    apiActions.postRequest(CONSTANTS.MedicalRecordAPIURL, medicalRecord, data => {
        CONSTANTS.title.innerText = "";
        console.log(data);
        CONSTANTS.content.innerHTML = pets.DisplayAllPets(data);
});
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