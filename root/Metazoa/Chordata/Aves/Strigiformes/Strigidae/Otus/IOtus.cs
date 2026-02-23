namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Interface defining characteristics of Otus (genus).
/// </summary>
public interface IOtus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
