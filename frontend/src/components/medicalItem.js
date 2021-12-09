import apiActions from "../api/apiActions";

export default{
    SetupMedicalItems,
    EditMedicalItemDetails,
    EditMedicalItem,
    SaveMedicalUpdatesBtn
}

function EditMedicalItemDetails(medItem){
    console.log('edit medical item button');
    let time = medItem.treatedOn.split(".")[0];
    return `
    <div id="editMedicalItem">
        Medical Item <input type="text" value="${medItem.itemType}" id="ItemType" /><br><br>
        Medical Item <select id="listMedItems"></select><br><br>
        Date Treated On <input type="datetime-local" value="${time}" id="TreatedOn" /><br><br>
        Description <input type="text" value="${medItem.description}" id="Description" /><br><br>
        <button id="btnSaveUpdatePet" class="btn btn-primary">Save</button>
        </div>
    `
    // const listMedicalItems = document.getElementById("listMedItems");


    // apiActions.getRequest(CONSTANTS.medicalItemAPIURL, items  =>
    //     {
    //         items.forEach( item =>
    //         {
    //             var option = document.createElement("option");
    //             option.value = item.id;
    //             option.text = item.itemType;
    //             option.text = item.treatedOn;
    //             option.text = item.artist.description;
    //             listMedicalItems.appendChild(option);
    //         });
    //     });

}

function SetupMedicalItems(){
    const btnSubmitMedItem = document.getElementById("btnSubmitMedItem");
    btnSubmitMedItem.addEventListener("click", function(){
        console.log("check add Medical Items");
        const newMedItem = {
            Id: 0,
            ItemType: document.getElementById("ItemType").value,
            TreatedOn: document.getElementById("TreatedOn").value,
            Description: document.getElementById("Description").value,
        }
        apiActions.postRequest(CONSTANTS.MedicalItemsAPIURL, newMedItem, data => {

            CONSTANTS.content.innerHTML = EditMedicalItemDetails(data);
        });
    });
}

function EditMedicalItem(pet) {
    console.log('edit medical item button');
    return `
        <input type="text" value="${pet.ItemType}" id="ItemType" />
        <input type="text" value="${pet.TreatedOn}" id="TreatedOn" />
        <input type="text" value="${pet.Description}" id="Description" />
        <button id="btnSaveUpdateItem" class="btn btn-primary">Save</button>
    `;

}

function SaveMedicalUpdatesBtn(){
    let btnSave = document.getElementById("btnSaveUpdateItem");
    btnSave.addEventListener("click", function () {
        console.log("click save button");
        let medicalItemId = document.getElementById("med_MedicalItemId").value;
        let itemType = document.getElementById("med_ItemType").value;
        let treatedOn = document.getElementById("med_TreatedOn").value;
        let description = document.getElementById("med_Description").value;

        const editMedItems = {
            MedicalItemId: medicalItemId,
            ItemType: itemType,
            TreatedOn: treatedOn,
            Description: description

        }
        apiActions.putRequest(CONSTANTS.MedicalItemsAPIURL, editMedItems, data => {
           console.log("click save updated button");
            CONSTANTS.content.innerHTML = MedicalDetails(data);
        });
    });
}
