import apiActions from "../api/apiActions";
import * as CONSTANTS from "./constants";
import medicalRecord from "./medicalRecord";

export default {
    SaveNewMedicalItemBtn,
    EditMedicalItemDetails,
    SaveMedicalUpdatesBtn,
    CreateNewMedicalItem
}

function EditMedicalItemDetails(medItem) {
    console.log('edit medical item button');
    let time = medItem.treatedOn.split(".")[0];
    return `
        <input type='hidden' id='med_MedicalItemId' value='${medItem.id}'/>
        <input type='hidden' id='med_MedicalRecordId' value='${medItem.medicalRecordId}'/>
        <select class="custom-select my-1 mr-sm-2" id="med_ItemType">
        <option selected>Select Type</option>
        <option value="${medItem.vaccination}">Vaccination</option>
        <option value="${medItem.surgery}">Surgery</option>
        <option value="${medItem.treatments}">Treatments</option>
        <option value="${medItem.fixed}">Fixed</option>
        <option value="${medItem.allergies}">Allergies</option>
        <option value="${medItem.medication}">Medication</option>
        </select>

        Date Treated On <input type="datetime-local" value="${time}" id="med_TreatedOn" />
        Description <input type="text" value="${medItem.description}" id="med_Description" />
        <button id="btnSaveUpdateMedItem">Save</button>
    `
    //Medical Item <input type="text" value="${medItem.itemType}" id="ItemType" />


    // const listMedicalItems = document.getElementById("listMedItems");

}

function CreateNewMedicalItem(petId) {
    console.log('edit medical item button');
    return `
        <input type='hidden' id='newMed_petId' value='${petId}'/>
        <select class="custom-select my-1 mr-sm-2" id="newMed_ItemType">
        <option selected>Select Type</option>
        <option>Vaccination</option>
        <option>Surgery</option>
        <option>Treatments</option>
        <option>Fixed</option>
        <option>Allergies</option>
        <option>Medication</option>
        </select>

        Date Treated On <input type="datetime-local" id="newMed_TreatedOn" />
        Description <input type="text"  id="newMed_Description" />
        <button id="btnSaveNewMedItem">Save</button>
    `
}

function SaveNewMedicalItemBtn(){
    let btnSubmitMedItem = document.getElementById("btnSaveNewMedItem");
    let petId = document.getElementById("newMed_petId").value;
    btnSubmitMedItem.addEventListener("click", function(){
        console.log("check add Medical Items");

        //let medicalRecordId = document.getElementById("newMed_MedicalRecordId").value;
        let selectList = document.getElementById("newMed_ItemType");
        let itemType = selectList.options[selectList.selectedIndex].text;
        if (itemType == "Select Type") {
            //print some error message
            return;
        }
        let treatedOn = document.getElementById("newMed_TreatedOn").value;
        let description = document.getElementById("newMed_Description").value; 

        const newMedicalItem = {
            Id: 0,
            ItemType: itemType,
            TreatedOn: treatedOn,
            Description: description,
            MedicalRecordId: 1
        }
        apiActions.postRequest(CONSTANTS.MedicalItemsAPIURL,newMedicalItem, data => {

            CONSTANTS.content.innerHTML = MedicalDetails(data);

        });
    });
}


function SaveMedicalUpdatesBtn() {
    let btnSave = document.getElementById("btnSaveUpdateMedItem");
    btnSave.addEventListener("click", function () {
        console.log("click save button");
        let medicalRecordId = document.getElementById("med_MedicalRecordId").value;
        let medicalItemId = document.getElementById("med_MedicalItemId").value;
        let selectList = document.getElementById("med_ItemType");
        let itemType = selectList.options[selectList.selectedIndex].text;
        if (itemType == "Select Type") {
            //print some error message
            return;
        }
        let treatedOn = document.getElementById("med_TreatedOn").value;
        let description = document.getElementById("med_Description").value;

        const editMedItems = {
            Id: medicalItemId,
            MedicalRecordId: medicalRecordId,
            ItemType: itemType,
            TreatedOn: treatedOn,
            Description: description

        }
        console.log(editMedItems);
        console.log("this is the item added");
        apiActions.putRequest(CONSTANTS.MedicalItemsAPIURL, medicalItemId, editMedItems, data => {
            console.log("click save updated button");

            CONSTANTS.content.innerHTML = medicalRecord.MedicalDetails(data);
            medicalRecord.setupMedicalItemLinks();


        });

    });
}