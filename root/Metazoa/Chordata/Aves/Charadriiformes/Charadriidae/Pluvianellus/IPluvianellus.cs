namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Pluvianellus;

/// <summary>
/// Interface defining characteristics of Pluvianellus (genus).
/// </summary>
public interface IPluvianellus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
