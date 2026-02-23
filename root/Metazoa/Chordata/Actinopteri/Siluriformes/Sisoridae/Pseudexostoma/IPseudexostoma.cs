namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudexostoma;

/// <summary>
/// Interface defining characteristics of Pseudexostoma (genus).
/// </summary>
public interface IPseudexostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
