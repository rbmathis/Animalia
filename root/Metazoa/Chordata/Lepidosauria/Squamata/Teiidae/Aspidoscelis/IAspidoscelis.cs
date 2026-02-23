namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Interface defining characteristics of Aspidoscelis (genus).
/// </summary>
public interface IAspidoscelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
