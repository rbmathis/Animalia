namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida;

/// <summary>
/// Interface defining characteristics of Saurida (genus).
/// </summary>
public interface ISaurida
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
