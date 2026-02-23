namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ameiurus;

/// <summary>
/// Interface defining characteristics of Ameiurus (genus).
/// </summary>
public interface IAmeiurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
