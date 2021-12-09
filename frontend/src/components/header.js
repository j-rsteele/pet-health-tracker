import * as CONSTANTS from "./constants.js";
import owner from "../components/owner";
import pets from "../components/pets";
import weight from "../components/weight";
import authorizedUser from "../components/authorizedUser";
import medicalItem from "../components/medicalItem";
import medicalRecord from "../components/medicalRecord";
import apiActions from "../api/apiActions";
import petProfile from "./petProfile";
import about from "../components/about";


export default {
    SetupNavBar,
    SetupAboutNav,
    SetupOwner,
    SetupPetNav,
    SetupPets
}

export function SetupNavBar() {
    SetupPets();
    return `
    <ul id="navbar">
        <li id="navPets">Pets</li>
        <li id="navOwner">Owner</li>
        <li id="navAbout">About</li>
    </ul>
    `;
}

function SetupPets() {
    apiActions.getRequest(CONSTANTS.PetAPIURL, data => {
        pets.DisplayAllPets(data);
        pets.RemovePet();
        pets.SetupPetLinks();
        pets.SetupAddPetButton();
        petProfile.SetupCreatePet();
        petProfile.SetupMedicalPageButton();
        weight.SetupWeightTracker();
    });
}

export function SetupOwner() {
    const ownerLink = document.getElementById('navOwner');

    ownerLink.addEventListener("click", function () {
         apiActions.getRequest(CONSTANTS.OwnerAPIURL+"1", data => {
        console.log("owner button clicked");
        CONSTANTS.content.innerHTML = owner.DisplayOwner(data);
        CONSTANTS.title.innerText = "";
        owner.SetupEditOwnerButton(data);
    })

    })}

     function SetupPetNav(){
        const petLink = document.getElementById('navPets');
        petLink.addEventListener("click", function(){
            SetupPets()
        })
     }

     function SetupAboutNav(){
        const aboutLink = document.getElementById('navAbout');
        aboutLink.addEventListener("click", function(){
            about.SetupAbout();
            
        })
    }

  