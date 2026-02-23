namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Exiliboa;

/// <summary>
/// Interface defining characteristics of Exiliboa (genus).
/// </summary>
public interface IExiliboa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
