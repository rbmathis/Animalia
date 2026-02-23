namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Xenopipo;

/// <summary>
/// Interface defining characteristics of Xenopipo (genus).
/// </summary>
public interface IXenopipo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
