# Changelog


## 2019-04-08
- Implement proper backoff with jitter for the retry logic

## 2019-04-08
- Refactor the data layer to separate read and write paths

## 2019-04-16
- Refactor the main entry point to make it easier to test

## 2019-04-18
- Clean up the deprecated alias and point callers to the new name

## 2019-04-22
- Remove the deprecated wrapper and use the library API directly

## 2019-04-24
- Simplify the CLI by merging the two similar subcommands into one

## 2019-04-24
- Fix bug where the parser would hang on malformed input

## 2019-04-26
- Refactor exports so the public API is clearer and easier to use

## 2019-04-30
- Fix the encoding issue when reading config files with non-ASCII
