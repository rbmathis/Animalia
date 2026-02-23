namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Sagittariidae.Sagittarius;

/// <summary>
/// Interface defining characteristics of Sagittarius (genus).
/// </summary>
public interface ISagittarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
