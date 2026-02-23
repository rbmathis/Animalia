namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Otolemur;

/// <summary>
/// Interface defining characteristics of Otolemur (genus).
/// </summary>
public interface IOtolemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
