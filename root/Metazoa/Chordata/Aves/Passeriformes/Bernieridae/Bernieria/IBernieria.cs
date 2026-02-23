namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Bernieria;

/// <summary>
/// Interface defining characteristics of Bernieria (genus).
/// </summary>
public interface IBernieria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
