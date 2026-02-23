namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae.Ancharius;

/// <summary>
/// Interface defining characteristics of Ancharius (genus).
/// </summary>
public interface IAncharius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
