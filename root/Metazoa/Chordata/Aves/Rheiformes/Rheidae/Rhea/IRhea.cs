namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Rheiformes.Rheidae.Rhea;

/// <summary>
/// Interface defining characteristics of Rhea (genus).
/// </summary>
public interface IRhea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
