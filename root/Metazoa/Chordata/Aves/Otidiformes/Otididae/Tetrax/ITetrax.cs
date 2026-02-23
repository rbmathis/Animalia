namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Tetrax;

/// <summary>
/// Interface defining characteristics of Tetrax (genus).
/// </summary>
public interface ITetrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
