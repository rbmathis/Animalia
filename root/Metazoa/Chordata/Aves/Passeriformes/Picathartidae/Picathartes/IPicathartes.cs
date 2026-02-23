namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae.Picathartes;

/// <summary>
/// Interface defining characteristics of Picathartes (genus).
/// </summary>
public interface IPicathartes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
