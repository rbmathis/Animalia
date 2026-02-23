namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Luetkenotyphlus;

/// <summary>
/// Interface defining characteristics of Luetkenotyphlus (genus).
/// </summary>
public interface ILuetkenotyphlus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
