import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import Pets from "../components/pets";

export default{
    MedicalDetails
}

let activeMedicalRecord = Pets.activePet;

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