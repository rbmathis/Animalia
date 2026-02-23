namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Indotyphlus;

/// <summary>
/// Interface defining characteristics of Indotyphlus (genus).
/// </summary>
public interface IIndotyphlus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
