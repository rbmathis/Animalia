namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Margarornis;

/// <summary>
/// Interface defining characteristics of Margarornis (genus).
/// </summary>
public interface IMargarornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
