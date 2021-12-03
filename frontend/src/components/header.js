import * as CONSTANTS from "./constants.js";
import owner from "../components/owner";
import pet from "./petProfile";
import pets from "../components/pets";
import weight from "../components/weight";
import authorizedUser from "../components/authorizedUser";
import medicalItem from "../components/medicalItem";
import medicalRecord from "../components/medicalRecord";
import apiActions from "../api/apiActions";
import { WebpackOptionsValidationError } from "webpack";

export default{
    SetupNavBar,
    SetupPets,
    SetupOwner
}

export function SetupNavBar(){
    SetupPets();
    SetupOwner();
    return `
    <ul> 
        <li id="navPets">Pets</li>
        <li id="navOwner">Owner</li>
        <li id="about">About</li>
    </ul>
    `;
}

function SetupPets() {
    apiActions.getRequest(CONSTANTS.PetAPIURL, data => {
        pets.DisplayAllPets(data);
        pets.SetupPetLinks();
    });
}

function SetupOwner() {
    const ownerLink = document.getElementById('navOwner');
    
    ownerLink.addEventListener("click", function() {
        apiActions.getRequest(CONSTANTS.OwnerAPIURL, data => {
            CONSTANTS.content.innerHTML = owner.DisplayOwner(data);
            CONSTANTS.title.innerText = "Owner";
            owner.SetupEditOwnerButton();
        })

})
    
}


