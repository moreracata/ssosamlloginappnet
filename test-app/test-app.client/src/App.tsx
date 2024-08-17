import { useEffect } from 'react';
import './App.css';



function App() {
    

    useEffect(() => {
       
    }, []);

 

    return (
        <div>
           
            <p>Request Login</p>
            <button type="button" 
                    className="btn btn-info"
                    onClick={requestLogin}>REQUEST LOGIN</button>
        </div>
    );


    async function requestLogin() {
        console.log("Requesting login")
        const response = await fetch('/api/login');
        const data = await response.json();
       console.log(data)
    }

   
}

export default App;