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

## 2019-05-14
- Support passing options through the config file as well as CLI

## 2019-05-20
- Clean up debug print statements before the release

## 2019-05-24
- Clean up the TODO comments that were already addressed

## 2019-05-28
- Update the deployment docs with the new environment variables

## 2019-05-30
- Adjust default timeout value to prevent premature connection drops

## 2019-05-30
- Adjust default timeout value to prevent premature connection drops

## 2019-06-07
- Handle the partial write case and retry the remaining bytes

## 2019-06-11
- Update README with installation steps and environment variable documentation

## 2019-06-13
- Support both YAML and JSON config formats for flexibility

## 2019-06-17
- Improve the error recovery when the database connection is lost

## 2019-06-17
- Remove obsolete workaround now that the upstream bug is fixed

## 2019-06-21
- Simplify the build script by using the same steps for dev and prod

## 2019-06-25
- Add integration tests for the new export endpoint
