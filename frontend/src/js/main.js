main js
import Header from "../components/header";
import * as CONSTANTS from "../components/constants";

const navbar = document.getElementById("navbar");

export default() => {
    setupNavbar();
}

function setupNavbar() {
    navbar.innerHTML = H.setUpNavBar();

}