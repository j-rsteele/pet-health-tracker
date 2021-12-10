import * as CONSTANTS from "./constants.js";
import pets from "../components/pets";
import apiActions from "../api/apiActions.js";
import petProfile from "./petProfile.js";
 
export default {
   //SetupWeightForm,
   //SetupWeightTracker,
   //SetupCreateWeight
}
 
 
// function SetupWeightTracker(){

//    CONSTANTS.content.innerHTML = SetupWeightForm();
//    SetupWeightSubmitBtn();
// }
 
// function SetupWeightSubmitBtn(){
//    const btnSubmitWeight = document.getElementById("btnSubmitWeight");
//    btnSubmitWeight.addEventListener('click', function(){
//       let petId = document.getElementById("WeightPetId").ToInt32();
   
   
   
//    })
//    SetupCreateWeight();
//    };

 
// function SetupWeightForm(petId){
// document.getElementById("title").innerText = "Enter Weight";
// console.log(petId);
// return`
// <div id="WeightForm">
// <form>
//    <label>Pet Weight</label>
//    <input type="hidden" id="petId">
//    <input id="petWeight"><br><br>
//    <label>Date</label>
//    <input type="date" id="weightDate"><br><br>
//    <input type="hidden" id="weightPetId" value=${petId.innerText}>
//    <input type="button" id="btnSubmitWeight" class="btn btn-primary" value="Submit">
//    <input type="button" id="btnListWeights" class="btn btn-primary" value="List Weights">
// </form>
// </div>
// `;
// }
 
// function SetupCreateWeight() {
//    const btnSubmitWeight = document.getElementById("btnSubmitWeight");
//    btnSubmitWeight.addEventListener("click", function(){
//        console.log("check add weight button");
//        let newWeight = {
//          Id: 0,
//          CurrentWeight: document.getElementById("petWeight").value,
//          Date: document.getElementById("weightDate").value,
//          PetId: document.getElementById('weightPetId').value
//        }
//        //CreateWeight(newWeight);
//        apiActions.postRequest(CONSTANTS.WeightAPIURL, newWeight, data => {
//           console.log(data);
//             CONSTANTS.content.innerHTML = petProfile.PetDetails(data.pet);
//             petProfile.SetupMedicalPageButton(data);
//                 petProfile.SetupUpdateMedicalRecord(data);
//                 petProfile.SetupWeightTrackerLink();
//        });
//    });
// }
 
// function SetupWeightList(){
//    const btnListWeights = document.getElementById("btnListWeights");
//    btnListWeights.addEventListener("click", function(){
//       CONSTANTS.content.innerHTML = DisplayListWeights();
//    })
// }
   
// function DisplayListWeights(){
//    return`
   
   
   
//    `
// }