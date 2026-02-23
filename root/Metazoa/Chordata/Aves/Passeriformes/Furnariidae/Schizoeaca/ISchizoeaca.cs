namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Schizoeaca;

/// <summary>
/// Interface defining characteristics of Schizoeaca (genus).
/// </summary>
public interface ISchizoeaca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
