import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'
import WelcomeMessage,{Welcome2React} from './WelcomeMessage'
import WelcomeInClass from './WelcomeInClass'
import StudentApp from './StudentApp'
import Displaybio from './Displaybio'
import ExpenseEntryitem from './Myprops'
//import MypropTypes from './MyPropTypes'
import StateAndprops from './StateAndProps'
import ClassWthSate from './ClassWithStates'
import MyPropTypes from './MyPropTypes'
import parentComp from './ParentComp'
import FindDomNodeApp from './FindDomNode'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
    <h1>My react App</h1>
    <p>this is my first react app</p>
    <p>Count: {count}</p>
    <button onClick={()=>setCount(count+1)}>Increment</button>
    {/* {/* <WelcomeMessage myname="react App Development"></WelcomeMessage>
    <Welcome2React></Welcome2React> }
    <WelcomeInClass myname="react app dvelopment"></WelcomeInClass>
    <StudentApp></StudentApp> */}
    {/* <Displaybio></Displaybio>
    <ExpenseEntryitem itemname="greatShakes Juice"></ExpenseEntryitem>
    <StateAndprops lang="React App Dev"></StateAndprops> */}
    <MyPropTypes></MyPropTypes>
    <ParentComp></ParentComp>
    </>
  )
}

export default App
