namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Hemicircus;

/// <summary>
/// Interface defining characteristics of Hemicircus (genus).
/// </summary>
public interface IHemicircus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
