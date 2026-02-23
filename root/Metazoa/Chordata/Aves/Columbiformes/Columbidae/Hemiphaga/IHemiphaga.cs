namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Hemiphaga;

/// <summary>
/// Interface defining characteristics of Hemiphaga (genus).
/// </summary>
public interface IHemiphaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
