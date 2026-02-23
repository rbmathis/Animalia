namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Furgaleus;

/// <summary>
/// Interface defining characteristics of Furgaleus (genus).
/// </summary>
public interface IFurgaleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
