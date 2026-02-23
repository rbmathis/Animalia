namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Cnidoglanis;

/// <summary>
/// Interface defining characteristics of Cnidoglanis (genus).
/// </summary>
public interface ICnidoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
