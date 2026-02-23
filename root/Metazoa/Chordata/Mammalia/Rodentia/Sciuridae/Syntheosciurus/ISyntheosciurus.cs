namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Syntheosciurus;

/// <summary>
/// Interface defining characteristics of Syntheosciurus (genus).
/// </summary>
public interface ISyntheosciurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
