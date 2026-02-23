namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Iridosornis;

/// <summary>
/// Interface defining characteristics of Iridosornis (genus).
/// </summary>
public interface IIridosornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
