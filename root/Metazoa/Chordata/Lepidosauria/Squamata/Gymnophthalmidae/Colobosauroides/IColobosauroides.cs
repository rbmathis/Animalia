namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Colobosauroides;

/// <summary>
/// Interface defining characteristics of Colobosauroides (genus).
/// </summary>
public interface IColobosauroides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
