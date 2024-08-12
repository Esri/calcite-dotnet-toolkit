# Contributing

Esri welcomes contributions from anyone and everyone. Please see our [guidelines for contributing](https://github.com/esri/contributing).

## I want to contribute, what should I work on?

You can help most by:

- Reporting issues by [filing a Bug issue](https://github.com/Esri/calcite-dotnet/issues/new?assignees=&labels=bug%2C0+-+new%2Cneeds+triage&template=bug.yml).
- Adding ideas for components by [creating a new issue](https://github.com/Esri/calcite-dotnet/issues/new?assignees=&labels=new+component%2C0+-+new%2Cneeds+triage&template=new-component.yml).
- Working on [the issues marked as `help wanted`](https://github.com/Esri/calcite-dotnet/issues?q=is%3Aopen+is%3Aissue+label%3A%22help+wanted%22+no%3Aassignee). There is also a [`good first issue`](https://github.com/Esri/calcite-dotnet/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22+no%3Aassignee+) label if you are just getting started.
  - To let us know of your interest in the issue, please comment on the issue and ask for the action items before you start working. Sometimes additional context is needed, which may not be specified in the issue. Comments also provide us access to assign the issue to you.
- If you want to help develop components take a look at the [new component issues](https://github.com/Esri/calcite-dotnet/issues?q=is%3Aopen+is%3Aissue+label%3A%22new+component%22).

If you aren't familiar with the basics of XAML Styling, please read through some of the following resources before contributing:

- [WPF - Styles and Templates]([https://developers.google.com/web/fundamentals/web-components/customelements](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/styles-templates-overview?view=netdesktop-8.0))
- [WinUI - XAML styles]([https://developers.google.com/web/fundamentals/web-components/shadowdom](https://learn.microsoft.com/en-us/windows/apps/design/style/xaml-styles))
- [.NET MAUI - Styles apps using XAML]([https://css-tricks.com/an-introduction-to-web-components/](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/styles/xaml?view=net-maui-8.0))

## Before filing an issue

Have you found a new bug? Want to request a new feature? We'd love to hear from you!

If something isn't working the way you expect, take a look at the [existing issues](https://github.com/Esri/calcite-dotnet/issues) before logging a new one. You can also report a bug or request an enhancement with [Esri Support](https://support.esri.com/en-us/contact), or ask questions, share ideas, and collaborate with others on [Esri Community](https://community.esri.com/t5/calcite-design-system/ct-p/calcite-design-system).

When filing an issue, provide all of the requested info from the appropriate [issue template](https://github.com/Esri/calcite-dotnet/issues/new/choose) so we can work on resolving the issue as soon as possible. A compileable sample that reproduces the issue is required for logging bugs.. Some other considerations:

- Use a clear and descriptive title
- Describe what is happening now vs what should happen
- Tell us how to reproduce the issue (e.g., is it happening in a specific browser?)
- Can it be reliably reproduced? If not, tell us how often it happens and under what circumstances.
- Screenshots and GIFs are welcome!
- Attached a zipped version of a cleaned project demonstrating the issue, or a link to a public repo.
- Did this problem start happening after a recent release, or was it always a bug?

## Issue management

### Labels

GitHub labels are used for organizing issues and providing context. You can familiarize yourself with the [label descriptions](https://github.com/Esri/calcite-dotnet/labels) to understand what they signify.

### Lifecycle

There are four issue lifecycle labels:

- `0 - new`: Issues that are up for grabs.
- `1 - assigned`: Issues that someone will work on soon.
- `2 - in development`: Issues are currently being worked on.
- `3 - installed`: Issues that have been merged to `main`.
- `4 - verified`: Issues that have been tested and are ready to close.

An issue can only have one of the lifecycle labels at any time. Please make sure to keep these up to date.

### Issues that cannot be worked on

There are four labels that mean an issue is not ready for development:

- `design`: Issues that need design consultation, such as interaction research/feedback, visual mockups, and general approval. Once design completes their review, an additional label, `ready for dev` will be added to the issue, which means a developer can pick up the issue.
- `spike`: Issues that need to research a question or resolve a complex task with uncertain outcomes. Once the spike has been performed a `spike complete` label is added to the issue, which means a developer can pick up the issue.
- `need more info`: Issues that are missing information and/or a clear, actionable description. This can mean we are waiting on a user to provide additional context, we can't reproduce the issue, or further discussion is needed in order to determine a solution.
- `blocked`: Issues that cannot be worked on until a different issue is resolved. The blocking issue may be from an external library (Stencil, Storybook, Jest, etc.) or a Calcite Components issue. The blocking issue should be linked to in the blocked issue's body or comment.

### Milestones

Milestones are used to organize issues targeted for a sprint in a planned release, and are not closed until all of the issues are verified. We have multiple milestones open at a time to help with future sprint planning. Calcite Core team members should grab issues from the current milestone when you are looking for something to work on. External contributors should ask before working on issues in upcoming milestones, since some of them need to be completed in a timely manner. There are also two constant milestones:

- **Stalled:** Issues we want to work on now, but are blocked, missing information, or require discussion to define action items. Try not to work on these issues unless an issue has a `spike` label and the research can be added to the issue for consideration in a future sprint.
- **Freezer:** Items that we want to look into, but do not have an immediate timeline associated. Try not to work on these issues unless they have a `help wanted` label.

### Estimates

Estimates are used to determine how much effort needs to go into an issue. The total estimate helps product managers triage issues effectively so designers and developers are not overwhelmed during sprints. If you are not on the team, please do not add estimates when creating cases. Here are some guidelines for time estimates using an `estimate-#` label for tracking:

### Design estimates

- `estimate - design - sm`: No more than a few days of design expertise.
- `estimate - design - md`: One to two weeks of design efforts and collaboration.
- `estimate - design - lg`: Two to four weeks of design expertise, collaboration, and discussion. Usually requires all hands on deck.

### Development estimates

- `estimate - 1`: Very small fix or change, a one line update.
- `estimate - 2`: Small fix or update, does not require updates to tests.
- `estimate - 3`: A day or two of effort, may require changes to tests.
- `estimate - 5`: A few days of effort, requires updates to tests.
- `estimate - 8`: Requires input from team, consider smaller steps.
- `estimate - 13`: Requires planning and input from team, consider smaller steps.
- `estimate - 21`: Requires planning, input from team members and possibly others.
- `estimate - 34`: Issue should be converted into an epic. Requires all hands on deck.

### Epics

Epics are specified by the `epic` label. Epics are changes that require a considerable effort and wouldn't fit into a single milestone. An epic should be a single concept, and have child issues for individual tasks created and listed in the epic's issue body.

## Code base

Our code base is written in C# and must adhere to analyzer-driven conventions and formatting.  Please do the following while developing:

1. Fix any warnings and, don't ignore them.
2. Provide [XML Doc](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags) for all public APIs.

## Getting a development environment set up

An installation of Visual Studio with the `.NET desktop development` (WPF),  `Windows application development` (WinUI) and `.NET Multi-platform App UI development` (.NET MAUI) workloads are required for development.

### Descriptive commit subject

The subject should contain a concise description of the proposed change, where contributors will:

- **Be succinct, yet informative** to ensure the change's purpose is conveyed once added to the changelog
- Describe the commit's purpose, not a related issue or how the change was mitigated
- Use present tense, such as "update" instead of "updated" or "updates"
- Not capitalize the first letter
- Not insert a period `.` at the end

### Contribution example

For instance, if providing a bug fix to the TextBlock component, which includes additional support to assistive technologies, you could use the following conventional commit:

```text
fix(text-area): provide additional support to assistive technologies
```

A more in-depth description can be added to the PR's body summary. For example:

```text
Related Issue: <Issue number>

### Summary
Provide additional context for assistive technology users when the component's character limit exceeds the `maxLength` property. Assistive technology users recieve an error message as soon as the character limit is exceeded.
```

For more information, explore [Stencil's contributing document](https://github.com/ionic-team/stencil/blob/main/CONTRIBUTING.md#commit-message-format). Please refer to the above link for more conventional commit details and examples, and visit [Calcite's recent commits](https://github.com/Esri/calcite-dotnet/commits/main) to refer to additional examples.

## Breaking changes

Calcite .NET team members should be consulted prior to submitting breaking change pull requests. For stability and consistency, breaking change sprints are coordinated and communicated well in advance.

When breaking changes are supported in a current milestone, commit messages for breaking changes should use both the header (`!`) and body (`BREAKING CHANGE:`) syntax.

The PR's details should be comprehensive, and when possible, include the following:

- What the proposed breaking change includes
- Why the breaking change is proposed
- An example to support users migrating from the previous major version (e.g., `1.x` to `2.x`)

```text
<type>(<scope>)!: <descriptive summary>

<optional info>

BREAKING CHANGE: <What the breaking change includes, why it is proposed, and migration support for users>
```

When adding a `BREAKING CHANGE:` note to the summary block right before confirming a squash merge, remove all the info except the `BREAKING CHANGE:` note itself, or else everything ends up being added to the changelog.

### Breaking change contribution example

For instance, if adding a refactored breaking change to the Modal component, you could use the following conventional commit:

```text
refactor(modal)!: rename `width` property to `widthScale`
```

And a more in-depth, but succinct description for the PR's body summary could include:

```text
Related Issue: <Issue number>
BREAKING CHANGE: For consistency, renames `width` property to `widthScale`.
```

See the [conventional commits doc](https://www.conventionalcommits.org/en/v1.0.0/) for more helpful information.

## Pull requests

In order to ensure conventional commits are followed, pull requests will run a check to indicate whether the PR is following the convention or not. The [Semantic Pull Request](https://github.com/amannn/action-semantic-pull-request) status check will ensure your pull requests are semantic before you merge them.

You can update the PR title any time before merging the PR. This may be necessary when the scope or type of the PR changes, or if additional details are needed for the changelog entry.

By default, the PR body will be used for the commit message when squash merging, so make sure to add any relevant details there.

### Visual snapshots

If the PR includes visual changes, include screenshots in the PR description demonstrating before and after, and update these if additional commits changes the look.
