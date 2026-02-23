namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Tachornis;

/// <summary>
/// Interface defining characteristics of Tachornis (genus).
/// </summary>
public interface ITachornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
