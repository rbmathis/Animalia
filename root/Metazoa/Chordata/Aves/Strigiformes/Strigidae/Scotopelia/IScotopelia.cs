namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Scotopelia;

/// <summary>
/// Interface defining characteristics of Scotopelia (genus).
/// </summary>
public interface IScotopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
