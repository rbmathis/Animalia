namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Prognatholiparis;

/// <summary>
/// Interface defining characteristics of Prognatholiparis (genus).
/// </summary>
public interface IPrognatholiparis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
