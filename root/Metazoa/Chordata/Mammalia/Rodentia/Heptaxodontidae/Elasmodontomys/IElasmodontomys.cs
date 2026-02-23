namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heptaxodontidae.Elasmodontomys;

/// <summary>
/// Interface defining characteristics of Elasmodontomys (genus).
/// </summary>
public interface IElasmodontomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
