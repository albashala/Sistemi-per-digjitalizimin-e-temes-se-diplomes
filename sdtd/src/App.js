import './App.css';
import {BrowserRouter as Router, Routes, Route} from 'react-router-dom';
import Home from './pages';
import SigninPage from './pages/signin';
import SignUpPage from './pages/signup';
import StudentProfile from './pages/studentProfile';
import Tema from './pages/tema';
import Termini from './pages/termini';



function App() {
  return (
    <Router>
      <Routes>
          <Route path="/" element={<Home/>} exact />
          <Route path="/signin" element={<SigninPage/>} exact />
          <Route path="/signup" element={<SignUpPage/>} exact />
          <Route path="/studentProfile" element={<StudentProfile/>} exact />
          <Route path="/tema" element={<Tema/>} exact />
          <Route path="/termini" element={<Termini/>} exact />
      </Routes>
    </Router>
  );
}


export default App;
