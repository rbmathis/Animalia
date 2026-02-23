namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae.Mesitornis;

/// <summary>
/// Interface defining characteristics of Mesitornis (genus).
/// </summary>
public interface IMesitornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
