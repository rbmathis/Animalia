namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Phoebastria;

/// <summary>
/// Interface defining characteristics of Phoebastria (genus).
/// </summary>
public interface IPhoebastria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
