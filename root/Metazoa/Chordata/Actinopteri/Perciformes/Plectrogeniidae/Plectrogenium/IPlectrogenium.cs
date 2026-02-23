namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Plectrogeniidae.Plectrogenium;

/// <summary>
/// Interface defining characteristics of Plectrogenium (genus).
/// </summary>
public interface IPlectrogenium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
