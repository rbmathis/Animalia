namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Cotinga;

/// <summary>
/// Interface defining characteristics of Cotinga (genus).
/// </summary>
public interface ICotinga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
