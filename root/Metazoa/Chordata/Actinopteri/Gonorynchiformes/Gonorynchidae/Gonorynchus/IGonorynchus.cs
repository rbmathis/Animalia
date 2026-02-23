namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Gonorynchidae.Gonorynchus;

/// <summary>
/// Interface defining characteristics of Gonorynchus (genus).
/// </summary>
public interface IGonorynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
