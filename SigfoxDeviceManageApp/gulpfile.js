/// <binding Clean='clean' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    clean = require("gulp-clean"),
    less = require("gulp-less"),
    rename = require("gulp-rename");
const { src, dest } = require("gulp");

var paths = {
    webroot: "./wwwroot/"
};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";
paths.less = "./Styles/less/**/*.less";

// Compile Less file to CSS file
gulp.task("less2css", () => {
    return src(paths.less)
        .pipe(less())
        .pipe(gulp.dest("./Styles/css/"));
    done();
});

gulp.task("contact", () => {
    return gulp.src([
        "./wwwroot/css/**/site.css",
        "./Styles/css/**/*.css"
    ])
        .pipe(concat("style.css"))
        .pipe(gulp.dest("./wwwroot/css/"));
    done();
});

gulp.task("minify", () => {
    return gulp.src("./wwwroot/css/**/style.css")
        .pipe(cssmin())
        .pipe(rename(
            "style.min.css"
        ))
        .pipe(dest("./wwwroot/css/min/"));
    done();
});

gulp.task("series",
    gulp.series(
        "less2css",
        "contact",
        "minify"
    )
);