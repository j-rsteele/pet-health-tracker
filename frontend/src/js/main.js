import Header from "../components/header";
import Pets from "../components/pets";
import * as CONSTANTS from "../components/constants";
const navbar = document.getElementById("navbar");
import apiActions from "../api/apiActions";

export default() => {
    setupHomeNav();
}

function setupHomeNav() {
    navbar.innerHTML = Header.SetupNavBar();
}