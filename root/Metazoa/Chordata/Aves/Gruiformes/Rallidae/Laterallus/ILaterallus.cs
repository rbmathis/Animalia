namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Laterallus;

/// <summary>
/// Interface defining characteristics of Laterallus (genus).
/// </summary>
public interface ILaterallus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
