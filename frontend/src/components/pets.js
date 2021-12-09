import * as CONSTANTS from "../components/constants";
import apiActions from "../api/apiActions";
import petProfile from "../components/petProfile";
import medicalRecord from "./medicalRecord";
import header from "../components/header";
import weight from "./weight";

export default {
    DisplayAllPets,
    SetupPetLinks,
    SetupAddPetButton,
    RemovePet
}

function DisplayAllPets(pets) {
    CONSTANTS.title.innerText = "Pets"

    console.log("displaying pets" + pets);
    CONSTANTS.content.innerHTML =
        `
        <ul id="petCards">

            ${pets.map(pet => {
                return `
                    <li>
                    <div class="card" style="width: 18rem;">
                    <img src="" class="card-img-top" alt="pet profile">
                    <div class="card-body">
                    <h5 class="card-title">${pet.name}</h5>
                    <a href="#" class="btn btn-primary petBtn" id="${pet.id}">View Pet</a>
                    <a href="#" class="btn btn-primary petDeleteBtn" id="${pet.id}">Delete Pet</a>
                    <input type='hidden' value='${pet.id}' />
                    </div>
                    </div>
                    </li>
                `
            }).join('')}
        </ul>
        <button class="btn btn-primary" id="btnAddPet">Add Pet</button>
    `;
}

function SetupAddPetButton() {
    const addPetButton = document.getElementById('btnAddPet');
    addPetButton.addEventListener('click', function() {
        console.log("add pet button connected");
        CONSTANTS.content.innerHTML = petProfile.SetupCreatePetForm();
        petProfile.SetupCreatePet();
    });
}

function RemovePet() {
    console.log("removing pet...");
    let petLinks = document.querySelectorAll(".petDeleteBtn");
    petLinks.forEach(petLink => {

        petLink.addEventListener("click", function (evt) {

            let petId = petLink.id;
            console.log("Pet Delete Id:" + petId);

            apiActions.deleteRequest(CONSTANTS.PetAPIURL, petId, data => {
                CONSTANTS.content.innerHTML = header.SetupPets();
            }); 
        });
    })
}


//Button for next page
function SetupPetLinks() {
    let petLinks = document.querySelectorAll(".petBtn");
    petLinks.forEach(petLink => {

        petLink.addEventListener("click", function (evt) {

            let petId = petLink.id;
            console.log("Pet Id:" + petId);

            apiActions.getRequest(CONSTANTS.PetAPIURL + petId, data => {
                CONSTANTS.content.innerHTML = petProfile.PetDetails(data);
                petProfile.SetupMedicalPageButton(data);
                petProfile.SetupUpdateMedicalRecord(data);
                petProfile.SetupWeightTrackerLink();
            });
        });
    })
};