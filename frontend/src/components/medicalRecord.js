import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import pets from "../components/pets";

export default{
    MedicalDetails
}

//let activeMedicalRecord = pets.activePet;

function MedicalDetails(){
    return `
    <ul id="listOfMedicalItems">

            ${medicalRecords.map(medItem =>{
            
                return `
                    <li>
                    ${medicalItem}
                    <input type='hidden' value='${medItem.id}' />
                    </li>
                `
            }).join('')}
            
        </ul>
    `
}