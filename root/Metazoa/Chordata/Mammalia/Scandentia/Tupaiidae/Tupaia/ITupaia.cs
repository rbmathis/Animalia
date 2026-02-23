namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Tupaia;

/// <summary>
/// Interface defining characteristics of Tupaia (genus).
/// </summary>
public interface ITupaia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
