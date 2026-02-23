namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Hologerrhum;

/// <summary>
/// Interface defining characteristics of Hologerrhum (genus).
/// </summary>
public interface IHologerrhum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
