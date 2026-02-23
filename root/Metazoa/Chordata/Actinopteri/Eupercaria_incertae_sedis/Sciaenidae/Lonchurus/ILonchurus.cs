namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Lonchurus;

/// <summary>
/// Interface defining characteristics of Lonchurus (genus).
/// </summary>
public interface ILonchurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
