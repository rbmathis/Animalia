namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Chelidoptera;

/// <summary>
/// Interface defining characteristics of Chelidoptera (genus).
/// </summary>
public interface IChelidoptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
