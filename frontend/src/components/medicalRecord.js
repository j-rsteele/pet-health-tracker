import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import medicalItem from "../components/medicalItem"

export default {
    MedicalDetails,
    UpdateMedicalRecord,
    SetupMedicalRecordSaveButton,
    setupMedicalItemLinks
}

function MedicalDetails(data) {
    console.log(data);
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
                    <input type='hidden' value='${medItem.id} class='medItemLinks'' />
                    <button id="${medItem.id}"class="btn btn-primary btnEditOneItem">Update</button>
                    </li>
                `
            }).join('')}
            
        </ul>
    `
    
}

function setupMedicalItemLinks() {
    let itemLinks = document.querySelectorAll(".btnEditOneItem");
    itemLinks.forEach(itemLink => {

        itemLink.addEventListener("click", function (evt) {

            let medicalItemId = itemLink.id;
            console.log("Medical Item ID: " + medicalItemId);

            apiActions.getRequest(CONSTANTS.MedicalItemsAPIURL + medicalItemId, data => {
                console.log(data);
                CONSTANTS.content.innerHTML = medicalItem.EditMedicalItemDetails(data);

            });
        });
    });
}

function UpdateMedicalRecord(data) {
    return `
<input type="hidden" id="medrec_medicalRecordId" value='${data.medicalRecord.id}'/>
<input type="hidden" id="medrec_petId" value='${data.medicalRecord.petId}'/>
<label>Primary Vet: </label><input type="text" id="medrec_primaryVet" value='${data.medicalRecord.primaryVet}'/>
<label>Clinic: </label><input type="text" id="medrec_clinic" value='${data.medicalRecord.clinic}'/>
<label>Phone: </label><input type="text" id="medrec_phone" value='${data.medicalRecord.phone}'/>
<label>Street: </label><input type="text" id="medrec_street" value='${data.medicalRecord.street}'/>
<label>City: </label><input type="text" id="medrec_city" value='${data.medicalRecord.city}'/>
<label>State: </label><input type="text" id="medrec_state" value='${data.medicalRecord.state}'/>
<label>Zip Code: </label><input type="text" id="medrec_zip" value='${data.medicalRecord.zip}'/>
<button id="btnSaveUpdateMedRec">Save</button>
`
}


function SetupMedicalRecordSaveButton() {
    let btnSave = document.getElementById("btnSaveUpdateMedRec");
    btnSave.addEventListener("click", function () {
        let medicalRecordId = document.getElementById("medrec_medicalRecordId").value;
        let primaryVet = document.getElementById("medrec_primaryVet").value;
        let clinic = document.getElementById("medrec_clinic").value;
        let phone = document.getElementById("medrec_phone").value;
        let street = document.getElementById("medrec_street").value;
        let city = document.getElementById("medrec_city").value;
        let state = document.getElementById("medrec_state").value;
        let zip = document.getElementById("medrec_zip").value;
        let petId = document.getElementById("medrec_petId").value;
        console.log(medicalRecordId);

        const editMedRecord = {
            Id: medicalRecordId,
            PrimaryVet: primaryVet,
            Clinic: clinic,
            Phone: phone,
            Street: street,
            City: city,
            State: state,
            Zip: zip,
            PetId: petId

        }
        apiActions.putRequest(CONSTANTS.MedicalRecordAPIURL, medicalRecordId, editMedRecord, data => {
           console.log(data);
        });
        apiActions.getRequest(CONSTANTS.PetAPIURL + petId, data => {
            CONSTANTS.content.innerHTML = MedicalDetails(data);
        });
    });
}