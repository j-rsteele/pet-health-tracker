import * as CONSTANTS from "../components/constants";
import apiActions from "../api/apiActions";
import petProfile from "../components/petProfile"


export default {
    DisplayAllPets,
    SetupPetLinks
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
                    <input type='hidden' value='${pet.id}' />
                    </div>
                    </div>
                    </li>
                `
            }).join('')}
        </ul>
        <button id="btnAddPet">Add Pet</button>
    `;

}


//Button for next page
function SetupPetLinks() {
    let petLinks = document.querySelectorAll(".petBtn");
    petLinks.forEach(petLink => {

        petLink.addEventListener("click", function (evt) {

            let petId = this.nextElementSibling.value;
            console.log("Pet Id:" + petId);

            apiActions.getRequest(CONSTANTS.PetAPIURL + petId, data => {
                CONSTANTS.content.innerHTML = petProfile.PetDetails(data);
                petProfile.SetupCreatePet()
            });
        });
    })
};