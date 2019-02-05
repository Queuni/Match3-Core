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

## 2019-06-25
- Improve the error recovery when the database connection is lost

## 2019-07-03
- Correct the docstring to match the actual behavior of the function

## 2019-07-09
- Improve error message when the required env var is not set

## 2019-07-09
- Refactor config loading into a separate module for better testability

## 2019-07-11
- Improve logging so we can trace requests through the pipeline in production

## 2019-07-15
- Simplify the validation flow by reusing the same schema

## 2019-07-17
- Update the API docs with the new query parameters and examples

## 2019-07-17
- Support passing options through the config file as well as CLI

## 2019-07-17
- Update the example config with all available options and comments

## 2019-07-31
- Remove the deprecated wrapper and use the library API directly

## 2019-08-12
- Handle the redirect response and follow it to get the final resource

## 2019-08-14
- Fix the off-by-one error in the date range iterator

## 2019-08-22
- Refactor exports so the public API is clearer and easier to use

## 2019-08-26
- Clean up unused imports and fix formatting to match the project style guide

## 2019-09-03
- Bump minimum Python version to 3.10 and update type hints accordingly

## 2019-09-03
- Remove the feature flag now that the feature is fully rolled out

## 2019-09-09
- Update the deployment docs with the new environment variables

## 2019-09-13
- Clean up the TODO comments that were already addressed

## 2019-09-19
- Clean up the commented-out code that was left from debugging

## 2019-09-19
- Add a smoke test that runs in CI to catch obvious regressions

## 2019-09-19
- Handle the case when the external service returns an empty list

## 2019-09-23
- Clean up the TODO comments that were already addressed

## 2019-09-23
- Improve the CLI help text so it's clear how to use each option

## 2019-09-27
- Add a unit test for the edge case when the list is empty

## 2019-10-01
- Update the license file and add the new third-party notices

## 2019-10-01
- Simplify the main loop by extracting request handling into a dedicated function

## 2019-10-03
- Fix issue where empty input was not validated before passing to the parser

## 2019-10-11
- Improve performance by caching the result of the expensive lookup

## 2019-10-11
- Implement fallback to default value when config key is missing

## 2019-10-15
- Improve error message when the required env var is not set

## 2019-10-15
- Remove the unused parameter that was left from an old refactor

## 2019-10-21
- Correct the logic that determined whether to use cache or not

## 2019-10-25
- Add integration tests for the new export endpoint

## 2019-10-29
- Handle the case when the external service returns an empty list

## 2019-10-31
- Refactor the data layer to separate read and write paths

## 2019-10-31
- Handle connection reset by the peer without crashing the worker

## 2019-11-04
- Correct the default value for the feature flag in production

## 2019-11-12
- Support passing options through the config file as well as CLI

## 2019-11-12
- Correct the formula used for calculating the backoff delay

## 2019-11-14
- Clean up debug print statements before the release

## 2019-11-14
- Refactor the helper to accept an optional callback for progress

## 2019-01-29
- Handle the duplicate key case by merging the values instead of failing

## 2019-01-31
- Update the contributing guide with the new review process

## 2019-02-01
- Correct the formula used for calculating the backoff delay

## 2019-02-01
- Bump dependency to get the security fix for the reported CVE

## 2019-02-04
- Simplify the main loop by extracting request handling into a dedicated function

## 2019-02-05
- Handle the duplicate key case by merging the values instead of failing
