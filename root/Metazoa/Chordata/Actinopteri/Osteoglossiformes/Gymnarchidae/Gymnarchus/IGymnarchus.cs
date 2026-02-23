namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Gymnarchidae.Gymnarchus;

/// <summary>
/// Interface defining characteristics of Gymnarchus (genus).
/// </summary>
public interface IGymnarchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
