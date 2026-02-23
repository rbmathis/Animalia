namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Ilicura;

/// <summary>
/// Interface defining characteristics of Ilicura (genus).
/// </summary>
public interface IIlicura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
