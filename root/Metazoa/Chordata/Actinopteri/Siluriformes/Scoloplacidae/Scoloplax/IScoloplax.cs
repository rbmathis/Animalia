namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Scoloplacidae.Scoloplax;

/// <summary>
/// Interface defining characteristics of Scoloplax (genus).
/// </summary>
public interface IScoloplax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
