import * as CONSTANTS from "./constants.js";
import owner from "../components/owner";
import pet from "../components/pet";
import pets from "../components/pets";
import weight from "../components/weight";
import authorizedUser from "../components/authorizedUser";
import medicalItem from "../components/medicalItem";
import medicalRecord from "../components/medicalRecord";
import apiActions from "../api/apiActions";

export default{
    SetupNavBar,
}

export function SetupNavBar(){
    return `
    <ul> 
        <li id="navPets">Pets</li>
        <li id="navAppointments">Appointments</li>
        <li id="navMedRecords">Medical Records</li>
        <li id="navWeightTracking">Weight Tracking</li>
        <li id="navSignOut">Sign Out</li>
    </ul>
    `;
}

