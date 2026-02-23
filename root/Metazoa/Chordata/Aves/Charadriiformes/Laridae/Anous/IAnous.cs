namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Anous;

/// <summary>
/// Interface defining characteristics of Anous (genus).
/// </summary>
public interface IAnous
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
