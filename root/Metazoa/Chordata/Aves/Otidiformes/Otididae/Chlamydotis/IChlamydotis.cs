namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Chlamydotis;

/// <summary>
/// Interface defining characteristics of Chlamydotis (genus).
/// </summary>
public interface IChlamydotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
