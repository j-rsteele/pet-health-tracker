import apiActions from "../api/apiActions";
import * as CONSTANTS from "./constants";

export default {
    DisplayOwner,
    SetupEditOwnerButton,
    //SetupAddOwner,
    EditOwner
}



// create owner
// export function SetupAddOwner(){
//     const btnAddOwner = document.getElementById("btnAddOwner");
//     btnAddOwner.addEventListener("click", function (){
//         //console.log('');
//         const newOwner = {
//             FirstName: document.getElementById("FirstName").value,
//             LastName: document.getElementById("LastName").value
//         }

//         apiActions.postRequest(CONSTANTS.OwnerAPIURL, newOwner, data => {
//             CONSTANTS.content.innerHTML = Owner.DisplayOwner(data);
//             Owner.SetupEditButton();
//         });
//     });
// }


// view owner

function DisplayOwner(owner) {
    return `
   <h4>Owner Information</h4>
   <ul id="ownerInformation">
  <input type="hidden" value="${owner.id}" id="ownerid" />
   <li>First Name: ${owner.firstName}</li>
   <li>Last Name: ${owner.lastName}</li>
   </ul>
   <button id="btnEditOwner">Edit</button>
   `
}

// update owner
function EditOwner(owner) {
    console.log(owner);
    return `
    <h4>Owner Information</h4>
        <input type="hidden" value="${owner.id}" id="owner_id" />
        <input type="text" value="${owner.firstName}" id="owner_first" />
        <input type="text" value="${owner.lastName}" id="owner_last" />
        <button id="btnSaveOwner">Update</button>
    `;
}

function SetupEditOwnerButton(owner) {
    let btnEdit = document.getElementById("btnEditOwner");
    btnEdit.addEventListener("click", function () {
        CONSTANTS.content.innerHTML = EditOwner(owner);
        SetupSaveOwnerButton();
    });
}

function SetupSaveOwnerButton() {
    let btnSave = document.getElementById("btnSaveOwner");
    btnSave.addEventListener("click", function () {
        let OwnerId = document.getElementById("owner_id").value;
        let OwnerFirst = document.getElementById("owner_first").value;
        let OwnerLast = document.getElementById("owner_last").value;
        const editOwner = {
            Id: OwnerId,
            FirstName: OwnerFirst,
            LastName: OwnerLast
        }
        apiActions.putRequest(CONSTANTS.OwnerAPIURL, OwnerId, editOwner, data => {
            console.log(data)
            CONSTANTS.content.innerHTML = DisplayOwner(data);
            //SetupEditOwnerButton();
        });
    });
}