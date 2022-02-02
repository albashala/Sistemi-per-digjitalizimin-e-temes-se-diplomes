import React, {useState} from 'react';
import Video from '../../videos/Video.mp4';
import {Button} from '../ButtonElement';
import {
     HeaderContainer,
     HeaderBg, 
     VideoBg,
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
            <VideoBg autoPlay loop muted src={Video} type='video/mp4'/>
        </HeaderBg>
        <HeaderContent>
                <HeaderH1>Tema e diplomes made easy</HeaderH1>
                <HeaderP> Krijoni nje llogari sot qe te keni nje proces sa me te thjeshte te zhvillimit te temes se diplomes.</HeaderP>
                <HeaderBtnWrapper>
                    <Button
                     to="singup" 
                     onMouseEnter={onHover}
                     onMouseLeave={onHover}
                     primary='true'
                     dark='true'
                    >
                        Get started {hover ? <ArrowForward/> : <ArrowRight/>}
                    </Button>
                </HeaderBtnWrapper>
        </HeaderContent>

    </HeaderContainer> 
  );
};

export default Header;
