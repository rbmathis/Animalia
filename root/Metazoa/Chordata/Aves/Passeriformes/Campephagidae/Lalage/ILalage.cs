namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Lalage;

/// <summary>
/// Interface defining characteristics of Lalage (genus).
/// </summary>
public interface ILalage
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
