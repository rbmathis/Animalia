namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Pampusana;

/// <summary>
/// Interface defining characteristics of Pampusana (genus).
/// </summary>
public interface IPampusana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
