import * as CONSTANTS from "./constants.js";
import pets from "../components/pets";
 
export default {
   setupWeightForm,
   setupWeightTracker
}
 
 
function setupWeightTracker(){
   CONSTANTS.content.innerHTML = setupWeightForm();
   setupWeightSubmitBtn();
 
}
 
function setupWeightSubmitBtn(pet){
   const btnSubmitWt = document.getElementById("btnSubmitWt");
   btnSubmitWt.addEventListener('click', function(){
      const newPetWt = {
      Id: 0,
      CurrentWeight: document.getElementById("petWt").value,
      Date: document.getElementById("wtDate").value,
      PetId: document.getElementById("pet.petId").value,
   }
   });
}
 
function setupWeightForm(){
   
return`
<div id="WtForm">
<form>
   <label>Pet Weight</label>
   <input id="petWt"><br><br>
   <label>Date</label>
   <input type="date" id="wtDate"><br><br>
   
   <input type="button" id="btnSubmitWt" value="submit">
</form>
</div>
`
}
 
function SetupCreateWt() {
   const btnSubmitPet = document.getElementById("btnSubmitWt");
   btnSubmitWt.addEventListener("click", function(){
       console.log("check add weight button");
       let newWeight = {
         Id: 0,
         CurrentWeight: document.getElementById("petWt").value,
         Date: document.getElementById("wtDate").value,
         PetId: document.getElementById("pet.petId").value,
       }
       CreateWeight(newWeight);
   });
}
 
// async function CreateWeight(newWeight) {
//    let weight = await fetch(CONSTANTS.WeightAPIURL, {
//        method: "POST",
//        headers: {
//            "Content-Type": "application/json"
//        },
//        body: JSON.stringify(newWeight)
//    })
//    .then(response => response.json())
   
//    let petId = pet.id;
 
//        let petWeight = document.getElementById("petWt").value;
//        let weightDate = document.getElementById("wtDate").value;
//        let petId = document.getElementById("pet.petId").value;
     
//        let newWeight = {
//        Id: 0,
//        CurrentWeight: petWeight,
//        Date: weightDate,
//        PetId: petId
//        }
// }
 
   
