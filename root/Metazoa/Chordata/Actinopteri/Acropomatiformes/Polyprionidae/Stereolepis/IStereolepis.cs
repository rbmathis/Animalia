namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae.Stereolepis;

/// <summary>
/// Interface defining characteristics of Stereolepis (genus).
/// </summary>
public interface IStereolepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
