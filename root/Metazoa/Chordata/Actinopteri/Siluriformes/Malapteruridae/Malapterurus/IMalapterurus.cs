namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Malapterurus;

/// <summary>
/// Interface defining characteristics of Malapterurus (genus).
/// </summary>
public interface IMalapterurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
