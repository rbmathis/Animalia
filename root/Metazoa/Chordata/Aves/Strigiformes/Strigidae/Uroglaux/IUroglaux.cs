namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Uroglaux;

/// <summary>
/// Interface defining characteristics of Uroglaux (genus).
/// </summary>
public interface IUroglaux
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
