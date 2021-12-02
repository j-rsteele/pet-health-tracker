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