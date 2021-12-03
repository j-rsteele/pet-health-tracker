import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import Pets from "../components/pets";
import medicalRecord from "./medicalRecord";

export default {
    PetDetails,
    SetupMedicalPageLink
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
        <input type="button" onclick="someFunction()" value="submit">
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

function CreatePet() {
    const btnAddPet = document.getElementById("btnAddPet");
    btnAddPet.addEventListener("click", function (){
        const newPet = {
            Name: document.getElementById("PetName").value,
            Age: document.getElementById("PetAge").value,
            Species: document.getElementById("PetSpecies").value,
            Breed: document.getElementById("PetBreed").value,
            Gender: document.getElementById("PetGender").value
            // upload picture?
        }

        apiActions.postRequest("https://localhost:44313/api/albums/", newAlbum, data => {

            pageContent.innerHTML = Album.DisplayAlbum(data);
            Album.SetupEditButton();
          
        });
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