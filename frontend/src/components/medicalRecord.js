import * as CONSTANTS from "./constants";
import apiActions from "../api/apiActions";
import medicalItem from "../components/medicalItem";
import petProfile from "../components/petProfile";
import pets from "./pets";

export default {
    MedicalDetails,
    UpdateMedicalRecord,
    SetupMedicalRecordSaveButton,
    setupMedicalItemLinks,
    SetupCreateNewMedicalItem
    //SetupBackButton
}

//button for back functionality
//<button id='backToPetProfile'>Back to Pet Profile</button>
function MedicalDetails(data) {
    console.log(data);
    return `
    <input type='hidden' id='medicalDetailPetId' value='${data.id}'/>
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
                    <input type='hidden' value='${medItem.id}'' class='medItemLinks' id='medId'/>
                    <button id="${medItem.id}"class="btn btn-primary btnEditOneItem">Update</button>
                    </li>
                `
            }).join('')}
            
        </ul>
        <input type='hidden' value='${data.id}'' class='medItemLinks' id='medRecId'/>
        <button id="createNewMedItem" class="btn btn-primary">Add New</button>
    `

}

// function SetupBackButton(){
//     let btnSave = document.getElementById("btnSaveUpdateMedRec");
//     btnSave.addEventListener("click", function () {
//         console.log("back to pet profile")
//         CONSTANTS.content.innerHTML = pets.DisplayAllPets
//     });
// }

function setupMedicalItemLinks() {
    let itemLinks = document.querySelectorAll(".btnEditOneItem");
    itemLinks.forEach(itemLink => {

        itemLink.addEventListener("click", function (evt) {

            let medicalItemId = itemLink.id;
            console.log("Medical Item ID: " + medicalItemId);

            apiActions.getRequest(CONSTANTS.MedicalItemsAPIURL + medicalItemId, data => {
                console.log(data);
                CONSTANTS.content.innerHTML = medicalItem.EditMedicalItemDetails(data);
                medicalItem.SaveMedicalUpdatesBtn();
                //SetupBackButton();
            });
        });
    });
}

function UpdateMedicalRecord(data) {
    return `
    <div id="updateMedicalRecord">
<input type="hidden" id="medrec_medicalRecordId" value='${data.medicalRecord.id}'/><br><br>
<input type="hidden" id="medrec_petId" value='${data.medicalRecord.petId}'/><br><br>
<label>Primary Vet: </label><input type="text" id="medrec_primaryVet" value='${data.medicalRecord.primaryVet}'/><br><br>
<label>Clinic: </label><input type="text" id="medrec_clinic" value='${data.medicalRecord.clinic}'/><br><br>
<label>Phone: </label><input type="text" id="medrec_phone" value='${data.medicalRecord.phone}'/><br><br>
<label>Street: </label><input type="text" id="medrec_street" value='${data.medicalRecord.street}'/><br><br>
<label>City: </label><input type="text" id="medrec_city" value='${data.medicalRecord.city}'/><br><br>
<label>State: </label><input type="text" id="medrec_state" value='${data.medicalRecord.state}'/><br><br>
<label>Zip Code: </label><input type="text" id="medrec_zip" value='${data.medicalRecord.zip}'/><br><br>
<button id="btnSaveUpdateMedRec" class="btn btn-primary">Save</button>
</div>
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
            CONSTANTS.content.innerHTML = petProfile.PetDetails(data);
            petProfile.SetupMedicalPageButton(data);
        });
    });
}

function SetupCreateNewMedicalItem() {
    let medId = document.getElementById("medRecId").value;
    let btnNew = document.getElementById("createNewMedItem");
    btnNew.addEventListener("click", function () {
        CONSTANTS.content.innerHTML = medicalItem.CreateNewMedicalItem(medId);
        medicalItem.SaveNewMedicalItemBtn();
    });
}