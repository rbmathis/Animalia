namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Euoticus;

/// <summary>
/// Interface defining characteristics of Euoticus (genus).
/// </summary>
public interface IEuoticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
