namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Prionodura;

/// <summary>
/// Interface defining characteristics of Prionodura (genus).
/// </summary>
public interface IPrionodura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
