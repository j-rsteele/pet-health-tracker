import apiActions from "../api/apiActions";
import * as CONSTANTS from "./constants";

var owner = null;

export default{
    DisplayOwner,
    SetupAddOwner,
    SetupOwner,
    EditOwner,
    // SetupOwnerDeleteButton
}



// create owner
export function SetupAddOwner(){
    const btnAddOwner = document.getElementById("btnAddOwner");
    btnAddOwner.addEventListener("click", function (){
        //console.log('add artist functionality goes here...');
        const newOwner = {
            FirstName: document.getElementById("FirstName").value,
            LastName: document.getElementById("LastName").value
        }

        apiActions.postRequest(CONSTANTS.OwnerAPIURL, newOwner, data => {
            CONSTANTS.content.innerHTML = Owner.DisplayOwner(data);
            Owner.SetupEditButton();
        });
    });
}


// view owner

function DisplayOwner(owner){
    return  `
   <h4>Owner Information</h4>
   <ul>
   <li> <input type="hidden" value="${owner.Id}" id="owner_id" /></li>
   <li>First Name: ${owner.FirstName}</li>
   <li>Last Name: ${owner.LastName}</li>
   </ul>
   <button id="btnEditOwner">Edit</button>
   `
}

// update owner
function EditOwner(owner){
    console.log(owner);
    return `
    <h4>Owner Information</h4>
        <input type="hidden" value="${owner.Id}" id="owner_id" />
        <input type="text" value="${owner.FirstName}" id="owner_first" />
        <input type="text" value="${owner.LastName}" id="owner_last" />
        <button id="btnSaveOwner">Update</button>
    `;
}

function SetupEditOwnerButton(){
    let btnEdit = document.getElementById("btnEditOwner");
    btnEdit.addEventListener("click", function(){
        CONSTANTS.content.innerHTML = EditOwner(Owner);
        SetupSaveOwnerButton();
    });
}

function SetupSaveOwnerButton(){
    let btnSave = document.getElementById("btnSaveOwner");
    btnSave.addEventListener("click", function(){
        let OwnerId = document.getElementById("owner_id").value;
        let OwnerFirst = document.getElementById("owner_first").value;
        let OwnerLast = document.getElementById("owner_last").value;
        const editOwner = {
            Id: OwnerId,
            FirstName: OwnerFirst,
            LastName: OwnerLast
        }
        apiActions.putRequest(CONSTANTS.OwnerAPIURL, OwnerId, editOwner, data => {
            CONSTANTS.content.innerHTML = DisplayOwner(data);
            SetupEditOwnerButton();
        });
    });
}

// delete owner

// function SetupOwnerDeleteButton(){
//         .addEventListener('click', function(){
//             let id = element.id;

//             apiActions.deleteRequest("https://localhost:44313/api/albums/", id, data => {
//                console.log("delete successful");
//                console.log(data);
//                 pageContent.innerHTML = DisplayAlbums(data);
//                 Header.GetAllArtists(); // figure out how to call GetAllArtsists
//                 SetupAddAlbum();
//             });
//         });
//     }