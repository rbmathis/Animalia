namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Mirafra;

/// <summary>
/// Interface defining characteristics of Mirafra (genus).
/// </summary>
public interface IMirafra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
