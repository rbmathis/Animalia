namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Stizorhina;

/// <summary>
/// Interface defining characteristics of Stizorhina (genus).
/// </summary>
public interface IStizorhina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
