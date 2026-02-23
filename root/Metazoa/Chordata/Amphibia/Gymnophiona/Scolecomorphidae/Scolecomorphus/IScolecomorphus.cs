namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae.Scolecomorphus;

/// <summary>
/// Interface defining characteristics of Scolecomorphus (genus).
/// </summary>
public interface IScolecomorphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
