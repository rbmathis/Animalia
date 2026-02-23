namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae.Velifer;

/// <summary>
/// Interface defining characteristics of Velifer (genus).
/// </summary>
public interface IVelifer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
