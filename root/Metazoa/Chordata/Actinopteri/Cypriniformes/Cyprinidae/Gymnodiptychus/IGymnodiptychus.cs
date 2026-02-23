namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnodiptychus;

/// <summary>
/// Interface defining characteristics of Gymnodiptychus (genus).
/// </summary>
public interface IGymnodiptychus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
