namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Aphanopus;

/// <summary>
/// Interface defining characteristics of Aphanopus (genus).
/// </summary>
public interface IAphanopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
