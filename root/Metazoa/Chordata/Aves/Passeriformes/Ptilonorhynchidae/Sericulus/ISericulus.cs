namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Sericulus;

/// <summary>
/// Interface defining characteristics of Sericulus (genus).
/// </summary>
public interface ISericulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
