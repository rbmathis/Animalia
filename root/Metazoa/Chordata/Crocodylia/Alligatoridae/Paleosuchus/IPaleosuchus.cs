namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Paleosuchus;

/// <summary>
/// Interface defining characteristics of Paleosuchus (genus).
/// </summary>
public interface IPaleosuchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
