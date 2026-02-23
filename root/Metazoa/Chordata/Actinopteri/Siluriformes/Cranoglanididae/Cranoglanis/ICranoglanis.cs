namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cranoglanididae.Cranoglanis;

/// <summary>
/// Interface defining characteristics of Cranoglanis (genus).
/// </summary>
public interface ICranoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
