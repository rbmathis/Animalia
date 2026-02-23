namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Cryptopipo;

/// <summary>
/// Interface defining characteristics of Cryptopipo (genus).
/// </summary>
public interface ICryptopipo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
