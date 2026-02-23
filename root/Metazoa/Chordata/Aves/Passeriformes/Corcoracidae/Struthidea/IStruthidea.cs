namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corcoracidae.Struthidea;

/// <summary>
/// Interface defining characteristics of Struthidea (genus).
/// </summary>
public interface IStruthidea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
