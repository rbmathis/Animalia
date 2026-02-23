namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Montivipera;

/// <summary>
/// Interface defining characteristics of Montivipera (genus).
/// </summary>
public interface IMontivipera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
