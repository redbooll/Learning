
//import "button" to .js from body 1st one to find
const button = document.querySelector('btn')

//imports body from document
const body = document.querySelector('body')

body.style.backgroundColor = 'black';

button.addEventListener('click', hexBg)

function hexBg(){
const hex = '#'+('00000'+(Math.random()*(1<<24)|0).toString(16)).slice(-6)
body.style.backgroundColor = hex
}