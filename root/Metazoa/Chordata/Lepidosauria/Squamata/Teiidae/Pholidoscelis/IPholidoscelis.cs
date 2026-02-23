namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Pholidoscelis;

/// <summary>
/// Interface defining characteristics of Pholidoscelis (genus).
/// </summary>
public interface IPholidoscelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
