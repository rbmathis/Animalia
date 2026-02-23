namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Glaucidium;

/// <summary>
/// Interface defining characteristics of Glaucidium (genus).
/// </summary>
public interface IGlaucidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
