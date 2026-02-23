namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Oreoica;

/// <summary>
/// Interface defining characteristics of Oreoica (genus).
/// </summary>
public interface IOreoica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
