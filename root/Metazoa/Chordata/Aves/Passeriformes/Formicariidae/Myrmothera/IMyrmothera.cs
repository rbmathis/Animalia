namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Myrmothera;

/// <summary>
/// Interface defining characteristics of Myrmothera (genus).
/// </summary>
public interface IMyrmothera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
