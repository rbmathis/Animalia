namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Ptilonorhynchus;

/// <summary>
/// Interface defining characteristics of Ptilonorhynchus (genus).
/// </summary>
public interface IPtilonorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
