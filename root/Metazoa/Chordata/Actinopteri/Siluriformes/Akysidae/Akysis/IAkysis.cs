namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Akysis;

/// <summary>
/// Interface defining characteristics of Akysis (genus).
/// </summary>
public interface IAkysis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
