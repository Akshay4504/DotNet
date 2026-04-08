import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'
import CallRef from './CallRef'
import MyForm1 from './MyForm1'
import MyForm2 from './MyForm2'
import MyForm3 from './Myform3'
import Person from './Person'
import BmiCalculator from './BMICalculator'
import ValidatingForms from './ValidatingForms'


function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      {/* <CallRef></CallRef> 
      <MyForm1></MyForm1>*/}
      {/* <MyForm2></MyForm2> */}
      {/* <MyForm3></MyForm3> */}
      {/* <Person></Person> */}
      {/* <BmiCalculator></BmiCalculator> */}
      <ValidatingForms></ValidatingForms>
    </>
  )
}

export default App
