namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Hydrolagus;

/// <summary>
/// Interface defining characteristics of Hydrolagus (genus).
/// </summary>
public interface IHydrolagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
