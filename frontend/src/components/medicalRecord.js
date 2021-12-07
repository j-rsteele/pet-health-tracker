import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";

export default {
    MedicalDetails,
    UpdateMedicalRecord,
    SetupMedicalRecordSaveButton
}

//let activeMedicalRecord = pets.activePet;

function MedicalDetails(data) {
    return `
    <ul id="listOfMedicalItems">

            ${data.medicalRecord.medicalItems.map(medItem =>{
                console.log(medItem)
            
                return `
                    <li>
                        <ul>
                            <li>${medItem.itemType}</li>
                            <li>${medItem.treatedOn}</li>
                            <li>${medItem.description}</li>

                    </ul>
                    <input type='hidden' value='${medItem.id}' />
                    </li>
                `
            }).join('')}
            
        </ul>
    `
}

function UpdateMedicalRecord(data) {
    return `
<input type="hidden" id="medrec_medicalRecordId" value='${data.medicalRecord.Id}'/>
<input type="text" id="medrec_primaryVet" value='${data.medicalRecord.primaryVet}'/>
<input type="text" id="medrec_clinic" value='${data.medicalRecord.clinic}'/>
<input type="text" id="medrec_phone" value='${data.medicalRecord.phone}'/>
<input type="text" id="medrec_street" value='${data.medicalRecord.street}'/>
<input type="text" id="medrec_city" value='${data.medicalRecord.city}'/>
<input type="text" id="medrec_state" value='${data.medicalRecord.state}'/>
<input type="text" id="medrec_zip" value='${data.medicalRecord.zip}'/>
<button id="btnSaveUpdatePet">Save</button>
`
}


function SetupMedicalRecordSaveButton() {
    let btnSave = document.getElementById("btnSaveUpdatePet");
    btnSave.addEventListener("click", function () {
        let medicalRecordId = document.getElementById("medrec_medicalRecordId").value;
        let primaryVet = document.getElementById("medrec_primaryVet").value;
        let clinic = document.getElementById("medrec_clinic").value;
        let phone = document.getElementById("medrec_phone").value;
        let street = document.getElementById("medrec_street").value;
        let city = document.getElementById("medrec_city").value;
        let state = document.getElementById("medrec_state").value;
        let zip = document.getElementById("medrec_zip").value;


        const editMedRecord = {
            MedicalRecordId: medicalRecordId,
            PrimaryVet: primaryVet,
            Clinic: clinic,
            Phone: phone,
            Street: street,
            City: city,
            State: state,
            Zip: zip

        }
        apiActions.putRequest(CONSTANTS.MedicalRecordAPIURL, medicalRecordId, editMedRecord, data => {
            console.log(data)
            CONSTANTS.content.innerHTML = MedicalDetails(data);
        });
    });
}