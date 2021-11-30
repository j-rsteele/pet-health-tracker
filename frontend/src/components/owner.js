import apiActions from "../api/apiActions";

var owner = null;

export default{
    DisplayOwner,
    SetupAddPetToOwner,
}

function DisplayOwner(owner){
    const OwnerApiUrl = "https://localhost:44322/api/Owner";
    console.log(owner);
    Owner = owner;
    if(owner.pets == null){
        owner.pets = [];

}

return `
        <h3>${owner.name}</h3>
        <button id="btnEditOwner">Edit</button>
        <ul>
            ${owner.pets.map(todo => {
                return `
                    <li>
                        ${pets.name}
                    </li>
                `
            }).join('')}
        </ul>
    `
}

function SetupAddPetToOwner(){
    let btnAddPet = document.getElementById("btnAddPet");
    btnAddPet.addEventListener("click", function (){
        //console.log('add owner functionality goes here...');
            Name: document.getElementById("ownerName").value
        });
    
}