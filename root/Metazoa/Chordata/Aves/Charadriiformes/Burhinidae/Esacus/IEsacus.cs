namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Esacus;

/// <summary>
/// Interface defining characteristics of Esacus (genus).
/// </summary>
public interface IEsacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
