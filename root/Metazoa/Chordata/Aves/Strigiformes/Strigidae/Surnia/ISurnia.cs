namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Surnia;

/// <summary>
/// Interface defining characteristics of Surnia (genus).
/// </summary>
public interface ISurnia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
