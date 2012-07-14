/* #Reset & Basics (Inspired by E. Meyers)
================================================== */
html, body, div, span, applet, object, iframe, h1, h2, h3, h4, h5, h6, p, blockquote, pre, a, abbr, acronym, address, big, cite, code, del, dfn, em, img, ins, kbd, q, s, samp, small, strike, strong, sub, sup, tt, var, b, u, i, center, dl, dt, dd, ol, ul, li, fieldset, form, label, legend, table, caption, tbody, tfoot, thead, tr, th, td, article, aside, canvas, details, embed, figure, figcaption, footer, header, hgroup, menu, nav, output, ruby, section, summary, time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline; }

article, aside, details, figcaption, figure, footer, header, hgroup, menu, nav, section {
  display: block; }

body {
  line-height: 1; }

ol, ul {
  list-style: none; }

blockquote, q {
  quotes: none; }

blockquote:before, blockquote:after,
q:before, q:after {
  content: '';
  content: none; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

/* #Basic Styles
================================================== */
body {
  background: #65686F;
  font: 14px/21px "HelveticaNeue", "Helvetica Neue", Helvetica, Arial, sans-serif;
  color: #FFF;
  -webkit-font-smoothing: antialiased;
  /* Fix for webkit rendering */
  text-align: left;
  height: 100%;
  margin: 0;
  background-repeat: no-repeat;
  background-attachment: fixed; }

h2, h4 {
  font-family: 'Interstate-LightCondensed';
  font-size: 90px;
  color: #dbdde2;
  color: #FFF;
  text-shadow: 0 1px 1px #323337;
  letter-spacing: -3px; }

h3 {
  font-size: 42px;
  font-family: 'Epic-MediumItalic';
  color: #161922;
  margin: 0;
  line-height: .6;
  text-shadow: 0 1px 1px #7e8189; }

.line_100 {
  line-height: 1; }

.line_150 {
  line-height: 1.5; }

h4 {
  font-family: 'Interstate';
  margin: 0.5em;
  color: #FFF;
  font-size: 34px;
  letter-spacing: -1px; }

p {
  font-family: 'Hand of Sean';
  font-size: 120px;
  text-align: center;
  font-weight: bold;
  color: #000;
  line-height: 1.5;
  text-transform: uppercase; }

p.smaller {
  font-size: 90px;
  line-height: 1.6; }

.globe {
  width: 630px;
  margin-top: -15px;
  padding-left: 23px; }

.github-is {
  background: url("http://cl.ly/I4LH/Screen%20Shot%202012-07-14%20at%206.28.31%20AM.png");
  width: 800px;
  height: 420px; }

.line-through {
  text-decoration: line-through; }

.profile {
  background: url("profile_picture.png") center;
  width: 320px;
  height: 320px;
  border-radius: 160px;
  box-shadow: inset 0 0 70px rgba(255, 255, 255, 0.69), 0 1px 1px rgba(0, 0, 0, 0.49);
  -webkit-filter: grayscale(0.6); }

.bird {
  padding: 20px;
  background: url("twitter-bird.png") center no-repeat; }

.whiteocat {
  padding: 20px;
  background: url("whiteocat.png") center no-repeat; }

.sublime {
  padding: 100px;
  height: 400px;
  width: 400px;
  background: url("codez.png") center; }

.right {
  float: right; }

.left {
  float: left; }

.clearfix:after {
  visibility: hidden;
  display: block;
  font-size: 0;
  content: " ";
  clear: both;
  height: 0; }

.clearfix {
  display: inline-block; }

/* start commented backslash hack \*/
* html .clearfix {
  height: 1%; }

.clearfix {
  display: block; }

/* close commented backslash hack */
.top_5 {
  margin-top: 5px; }

.top_7 {
  margin-top: 7px; }

.top_8 {
  margin-top: 8px; }

.top_10 {
  margin-top: 10px; }

.top_15 {
  margin-top: 15px; }

.top_20 {
  margin-top: 20px; }

.top_25 {
  margin-top: 25px; }

.top_30 {
  margin-top: 30px; }

.top_35 {
  margin-top: 35px; }

.top_40 {
  margin-top: 40px; }

.top_45 {
  margin-top: 45px; }

.top_50 {
  margin-top: 50px; }

.top_55 {
  margin-top: 55px; }

.top_60 {
  margin-top: 60px; }

.top_65 {
  margin-top: 65px; }

.top_70 {
  margin-top: 70px; }

.top_75 {
  margin-top: 75px; }

.top_80 {
  margin-top: 80px; }

.top_85 {
  margin-top: 85px; }

.top_100 {
  margin-top: 100px; }

.top_110 {
  margin-top: 110px; }

.top_115 {
  margin-top: 115px; }

.top_120 {
  margin-top: 120px; }

.top_150 {
  margin-top: 150px; }

.top_175 {
  margin-top: 175px; }

.top_200 {
  margin-top: 200px; }

.top_225 {
  margin-top: 225px; }

.top_250 {
  margin-top: 250px; }

.left_0 {
  margin-left: 0; }

.left_7 {
  margin-left: 7px; }

.left_8 {
  margin-left: 8px; }

.left_9 {
  margin-left: 9px; }

.left_10 {
  margin-left: 10px; }

.left_12 {
  margin-left: 12px; }

.left_15 {
  margin-left: 15px; }

.left_20 {
  margin-left: 20px; }

.left_25 {
  margin-left: 25px; }

.left_30 {
  margin-left: 30px; }

.left_35 {
  margin-left: 35px; }

.left_40 {
  margin-left: 40px; }

.left_45 {
  margin-left: 45px; }

.left_50 {
  margin-left: 50px; }

.left_60 {
  margin-left: 60px; }

.left_63 {
  margin-left: 63px; }

.left_65 {
  margin-left: 65px; }

.left_70 {
  margin-left: 70px; }

.left_75 {
  margin-left: 75px; }

.left_80 {
  margin-left: 80px; }

.left_85 {
  margin-left: 85px; }

.left_90 {
  margin-left: 90px; }

.left_95 {
  margin-left: 95px; }

.left_100 {
  margin-left: 100px; }

.left_105 {
  margin-left: 105px; }

.left_110 {
  margin-left: 110px; }

.left_115 {
  margin-left: 115px; }

.left_120 {
  margin-left: 120px; }

.left_125 {
  margin-left: 125px; }

.left_140 {
  margin-left: 140px; }

.left_160 {
  margin-left: 160px; }

.right_0 {
  margin-right: 0; }

.right_5 {
  margin-right: 5px; }

.right_7 {
  margin-right: 7px; }

.right_8 {
  margin-right: 8px; }

.right_9 {
  margin-right: 9px; }

.right_12 {
  margin-right: 12px; }

.right_10 {
  margin-right: 10px; }

.right_20 {
  margin-right: 20px; }

.right_25 {
  margin-right: 25px; }

.right_50 {
  margin-right: 50px; }

.right_52 {
  margin-right: 52px; }

.vacuum {
  margin-top: 70px; }

.bottom_0 h3 {
  margin-bottom: 0; }

.bottom_0 {
  margin-bottom: 0; }

.bottom_20 {
  margin-bottom: 20; }

.t0 {
  margin-top: 0; }

.t1 {
  margin-top: 1em; }

.t2 {
  margin-top: 2em; }

.t3 {
  margin-top: 3em; }

.t4 {
  margin-top: 4em; }

.t5 {
  margin-top: 5em; }

.t6 {
  margin-top: 6em; }

.t7 {
  margin-top: 7em; }

.t8 {
  margin-top: 8em; }

.t9 {
  margin-top: 9em; }

.b1 {
  margin-bottom: 1em; }

.b2 {
  margin-bottom: 2em; }

.b3 {
  margin-bottom: 3em; }

.b4 {
  margin-bottom: 4em; }

.b5 {
  margin-bottom: 5em; }

.r1 {
  margin-right: 1em; }

.r2 {
  margin-right: 2em; }

.r3 {
  margin-right: 3em; }

.r4 {
  margin-right: 4em; }

.r5 {
  margin-right: 5em; }

.r6 {
  margin-right: 6em; }

.r7 {
  margin-right: 7em; }
