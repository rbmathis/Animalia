namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Ardeotis;

/// <summary>
/// Interface defining characteristics of Ardeotis (genus).
/// </summary>
public interface IArdeotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
