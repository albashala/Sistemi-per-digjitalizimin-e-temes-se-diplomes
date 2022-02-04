import React from 'react';
import {FaBars} from 'react-icons/fa';
import { useAuth0 } from '@auth0/auth0-react';

import {
    Nav,
    NavbarContainer, 
    NavLogo, 
    MobileIcon, 
    NavMenu, 
    NavItem, 
    NavLinks,
    NavBtn,
    NavBtnLink
} from './NavbarElements';

const Navbar = ({ toggle }) => {
    const {
        isLoading,
        isAuthenticated,
        error,
        user,
        loginWithRedirect,
        logout,
      } = useAuth0();
  return (
    <>
        <Nav>
            <NavbarContainer>
                <NavLogo to='/'> <img src={require('./ubtlogo.png')} style={{width:"10%"}}/></NavLogo>
                <MobileIcon onClick={toggle}>
                    <FaBars/>
                </MobileIcon>
                <NavMenu>
                    <NavItem>
                        <NavLinks to="about">About</NavLinks>
                    </NavItem>
                    <NavItem>
                        <NavLinks to="/signup">Sign up</NavLinks>
                    </NavItem>
                </NavMenu>
                <NavBtn>
                    <NavBtnLink to="/signin">Sign In</NavBtnLink>
                </NavBtn>
                {/* <NavBtn onClick={loginWithRedirect}>Sign in</NavBtn> */}
            </NavbarContainer>
        </Nav>
    </>
  );
};

export default Navbar ;
