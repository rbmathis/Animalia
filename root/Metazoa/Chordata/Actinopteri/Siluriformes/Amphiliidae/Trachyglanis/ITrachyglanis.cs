namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Trachyglanis;

/// <summary>
/// Interface defining characteristics of Trachyglanis (genus).
/// </summary>
public interface ITrachyglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
