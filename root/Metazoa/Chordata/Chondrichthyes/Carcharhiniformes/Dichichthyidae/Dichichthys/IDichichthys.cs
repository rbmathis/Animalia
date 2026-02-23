namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Dichichthyidae.Dichichthys;

/// <summary>
/// Interface defining characteristics of Dichichthys (genus).
/// </summary>
public interface IDichichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
