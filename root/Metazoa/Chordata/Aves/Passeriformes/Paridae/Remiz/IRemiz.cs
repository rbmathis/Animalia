namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Remiz;

/// <summary>
/// Interface defining characteristics of Remiz (genus).
/// </summary>
public interface IRemiz
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
