namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae.Beryx;

/// <summary>
/// Interface defining characteristics of Beryx (genus).
/// </summary>
public interface IBeryx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
