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

## [0.3.0] - 2019-11-16
### Added
- General purpose state machine to build on top of (examples to come in future versions)
- Tests for state machine logic mentiond above
- Moq package for Mocking in Unit Tests (check README.md)
- A Transform extension for destroying child objects

### Changed
- README.md to explain Moq dependency

### Removed
- Component extensions (I currently see no use as they were just copies of the GameObject extensions)

## [0.4.0] - 2019-11-16
### Added
- ScriptableObject events
- First reusable component (timer)
- Tests for the timer component

## [0.4.1] - 2019-11-16
### Added
- Assembly definitions for the (currently) empty editor folders so they are added to Git

## [0.5.0] - 2019-11-16
### Changed
- State now has a list of StateAction to allow multiple things to happen in a single state (examples to come in future versions)

### Removed
- Moq.meta to get rid of warnings

## [0.6.0] - 2019-11-17

### Added
- Some new scripts to handle movement and gravity as movement modifiers (more movement modifiers to come)
- Tests for scripts mentioned above

### Changed
- States now enable and disable the GameObject they are attatched to when entering and exiting respectively

## [0.7.0] - 2019-11-19

### Added
- Serialized types for Vector2, Vector3, and Quaternion
- Moq and its dependencies along with their respective licenses (there's no longer a need to install and set it up yourself)
- Default values for all fields with the SerializeField attribute as they were causing compiler warnings without (due to the compiler not being aware that private fields can actually be set inside Unity)

### Changed
- Fixed typo "Shuffel" to "Shuffle" in ListExtensions

### Removed
- StateAction as there is no need. Simply use the OnEnable, Update, and OnDisable callbacks in a Monobehaviour instead of Enter, Tick, and Exit that was in a StateAction.

## [0.8.0] - 2019-11-19

### Added
- Wrapper for the new Unity Input system (examples to come and I'll probably make a video about it)
