namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Urolestes;

/// <summary>
/// Interface defining characteristics of Urolestes (genus).
/// </summary>
public interface IUrolestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
