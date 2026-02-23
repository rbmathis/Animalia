namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae.Fregata;

/// <summary>
/// Interface defining characteristics of Fregata (genus).
/// </summary>
public interface IFregata
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
