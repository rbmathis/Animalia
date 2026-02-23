namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Ferminia;

/// <summary>
/// Interface defining characteristics of Ferminia (genus).
/// </summary>
public interface IFerminia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
