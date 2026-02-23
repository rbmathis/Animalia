namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Mastiglanis;

/// <summary>
/// Interface defining characteristics of Mastiglanis (genus).
/// </summary>
public interface IMastiglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
