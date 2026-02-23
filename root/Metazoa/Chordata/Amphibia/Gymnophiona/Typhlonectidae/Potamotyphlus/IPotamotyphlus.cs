namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Potamotyphlus;

/// <summary>
/// Interface defining characteristics of Potamotyphlus (genus).
/// </summary>
public interface IPotamotyphlus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
