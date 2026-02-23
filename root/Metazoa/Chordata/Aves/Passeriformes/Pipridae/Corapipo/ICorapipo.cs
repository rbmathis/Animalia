namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Corapipo;

/// <summary>
/// Interface defining characteristics of Corapipo (genus).
/// </summary>
public interface ICorapipo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
