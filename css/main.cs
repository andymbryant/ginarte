@import url("https://fonts.googleapis.com/css?family=Lato:400,700|Montserrat:900");
html {
  display: grid;
  min-height: 100%;
}

body {
  display: grid;
  background: white;
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

.panel {
  background-color: #EF2F3C;
  position: absolute;
  top: 0;
  height: 100%;
  width: 50%;
}

.left {
  left: 0;
}

.right {
  right: 0;
}

.maple {
  position: absolute;
  left: 0;
  right: 0;
  margin-left: auto;
  margin-right: auto;
}

.container {
  position: relative;
  margin: auto;
  overflow: hidden;
  width: 650px;
  height: 480px;
}

h1 {
  font-family: "Lato", sans-serif;
  text-align: center;
  margin-top: 2em;
  font-size: 1em;
  text-transform: uppercase;
  letter-spacing: 5px;
  color: white;
}

#timer {
  color: white;
  text-align: center;
  text-transform: uppercase;
  font-family: "Lato", sans-serif;
  font-size: 0.7em;
  letter-spacing: 5px;
  margin-top: 25%;
}

.days, .hours, .minutes, .seconds {
  display: inline-block;
  padding: 20px;
  width: 100px;
  border-radius: 5px;
}

.days {
  background: #EF2F3C;
}

.hours {
  background: white;
  color: #183059;
}

.minutes {
  background: #276FBF;
}

.seconds {
  background: #F0A202;
}

.numbers {
  font-family: "Montserrat", sans-serif;
  color: #183059;
  font-size: 5em;
}

/*# sourceMappingURL=main.cs.map */
