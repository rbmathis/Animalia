namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dasyornithidae.Dasyornis;

/// <summary>
/// Interface defining characteristics of Dasyornis (genus).
/// </summary>
public interface IDasyornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
