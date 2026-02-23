namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Elaphrornis;

/// <summary>
/// Interface defining characteristics of Elaphrornis (genus).
/// </summary>
public interface IElaphrornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
