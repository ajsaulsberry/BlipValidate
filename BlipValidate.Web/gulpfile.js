var gulp = require('gulp')
var merge = require('merge-stream')

gulp.task('default', defaultTask)
gulp.task('scripts', scriptTask)

function defaultTask (done) {
  // place code for your default task here
  done()
}

// Dependency Dirs
var deps = {
  'jquery': {
    'dist/*': ''
  },
  'bootstrap': {
    'dist/**/*': ''
  },
  'jquery-validation': {
    'dist/*': ''
  },
  'jquery-validation-unobtrusive': {
    'jquery.validate*': ''
  }
}

function scriptTask () {
  var streams = []
  for (var prop in deps) {
    console.log('Prepping Scripts for: ' + prop)
    for (var itemProp in deps[prop]) {
      streams.push(gulp.src('node_modules/' + prop + '/' + itemProp)
        .pipe(gulp.dest('wwwroot/lib/' + prop + '/' + deps[prop][itemProp])))
    }
  }
  return merge(streams)
}
