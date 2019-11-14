# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.1.0] - 2019-11-13
### Added
- An example string extension
- A couple of example list extensions
- Tests for list extensions mentioned above

## [0.2.0] - 2019-11-14
### Added
- Comments for every method in the package
- A few Component extensions
- Component tests for extensions mentioned above
- A few GameObject extensions
- GameObject tests for extensions mentioned above
- Quite a few Vector extensions to easily change single components
- Vector tests for extensions mentioned above
- A few list extensions for shuffling and picking random elements

### Changed
- StringExtensions.AsColour to WithColour

### Removed
- ListExtensions.First and ListExtensions.Last (Use System.Linq instead)
