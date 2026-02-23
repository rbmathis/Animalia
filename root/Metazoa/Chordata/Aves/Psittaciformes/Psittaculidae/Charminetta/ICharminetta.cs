namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Charminetta;

/// <summary>
/// Interface defining characteristics of Charminetta (genus).
/// </summary>
public interface ICharminetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
