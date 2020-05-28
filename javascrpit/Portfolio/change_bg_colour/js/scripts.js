

//import "button" to .js from body 1st one to find
const button = document.querySelector('button')

//imports body from document
const body = document.querySelector('body')

//collor array variable 
const colors = ['black','green','purple','yellow','blue']


//set initial bg colour of body
body.style.backgroundColor = 'violet'

//set the trigger 
button.addEventListener('click', changeBackground)

//fuction to radomize change of bg from array
function changeBackground(){
const colorIndex= parseInt(Math.random()*colors.length)
body.style.backgroundColor = colors[colorIndex]
}
