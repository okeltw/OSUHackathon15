$(function(){
    $.get("https://api.twitter.com/1.1/search/tweets.json?q=%40twitterapi", function (data) {
        console.log(data);
    });
});