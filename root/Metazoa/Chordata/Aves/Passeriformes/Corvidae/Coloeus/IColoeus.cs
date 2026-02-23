namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Coloeus;

/// <summary>
/// Interface defining characteristics of Coloeus (genus).
/// </summary>
public interface IColoeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
