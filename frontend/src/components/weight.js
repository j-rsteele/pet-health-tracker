import * as CONSTANTS from "./constants.js";
import pets from "../components/pets";
 
export default {
   SetupWeightForm,
   SetupWeightTracker
}
 
 
function SetupWeightTracker(pet){

   CONSTANTS.content.innerHTML = SetupWeightForm();
   SetupWeightSubmitBtn(pet);
 
}
 
function SetupWeightSubmitBtn(pet){
   const btnSubmitWeight = document.getElementById("btnSubmitWeight");
   btnSubmitWeight.addEventListener('click', function(){

   })
   SetupCreateWeight();
   };

 
function SetupWeightForm(){
document.getElementById("title").innerText = "Enter Weight";
return`
<div id="WeightForm">
<form>
   <label>Pet Weight</label>
   <input id="petWeight"><br><br>
   <label>Date</label>
   <input type="date" id="weightDate"><br><br>
   
   <input type="button" id="btnSubmitWeight" value="submit">
</form>
</div>
`
}
 
function SetupCreateWeight() {
   const btnSubmitWeight = document.getElementById("btnSubmitWeight");
   btnSubmitWeight.addEventListener("click", function(){
       console.log("check add weight button");
       let newWeight = {
         Id: 0,
         CurrentWeight: document.getElementById("petWeight").value,
         Date: document.getElementById("weightDate").value,
         PetId: pet.petId,
       }
       CreateWeight(newWeight);
   });
}
 
async function CreateWeight(newWeight) {
   let weight = await fetch(CONSTANTS.WeightAPIURL, {
       method: "POST",
       headers: {
           "Content-Type": "application/json"
       },
       body: JSON.stringify(newWeight)
   })
   .then(response => response.json())
   console.log(weight)
}
 
   
