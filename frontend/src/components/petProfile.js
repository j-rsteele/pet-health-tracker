import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";

export default {
    PetDetails,
    SetupPetDetailLinks
}

function PetDetails(pet) {
    return `
    <ul>
    <li>${pet.photo}</li>
    <li>Name: ${pet.name}</li>
    <li>Age: ${pet.age}</li>
    <li>Species: ${pet.species}</li>
    <li>Breed: ${pet.breed}</li>
    <li>Gender: ${pet.gender}</li>
    </ul>
    `
}

// function SetupPetDetailLinks() {
//     let petLinks = document.querySelectorAll(".petBtn");
//     petLinks.forEach(petLink => {

//         petLink.addEventListener("click", function (evt) {

//             let petId = this.nextElementSibling.value;
//             console.log("Pet Id:" + petId);

//             apiActions.getRequest(CONSTANTS.PetAPIURL + petId, data => {
//                 CONSTANTS.content.innerHTML = petProfile.petDetails(data);
//             });
//         });
//     })
// };