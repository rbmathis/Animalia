namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Elminia;

/// <summary>
/// Interface defining characteristics of Elminia (genus).
/// </summary>
public interface IElminia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
