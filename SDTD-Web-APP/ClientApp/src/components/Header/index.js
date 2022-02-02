import React, {useState} from 'react';
import {Button} from '../ButtonElement';
import {
     HeaderContainer,
     HeaderBg, 
     HeaderContent, 
     HeaderH1, 
     HeaderP, 
     HeaderBtnWrapper,
    ArrowForward,
    ArrowRight  } from './HeaderElements';

const Header = () => {
    const [hover, setHover] = useState(false)

    const onHover = () => {
        setHover(!hover)
    }

  return (
    <HeaderContainer>
        <HeaderBg>
            <HeaderContent>
                <HeaderH1>Tema e diplomes made easy</HeaderH1>
                <HeaderP> Krijoni nje llogari sot qe te keni nje proces sa me te thjeshte te zhvillimit te temes se diplomes.</HeaderP>
                <HeaderBtnWrapper>
                    <Button to="singup" onMouseEnter={onHover}
                    onMouseLeave={onHover}>
                        Get started {hover ? <ArrowForward/> : <ArrowRight/>}
                    </Button>
                </HeaderBtnWrapper>
            </HeaderContent>

        </HeaderBg>

    </HeaderContainer> 
  );
};

export default Header;
