namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Eulabeornis;

/// <summary>
/// Interface defining characteristics of Eulabeornis (genus).
/// </summary>
public interface IEulabeornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
