namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodontomys;

/// <summary>
/// Interface defining characteristics of Sigmodontomys (genus).
/// </summary>
public interface ISigmodontomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
