namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Lethrinus;

/// <summary>
/// Interface defining characteristics of Lethrinus (genus).
/// </summary>
public interface ILethrinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
