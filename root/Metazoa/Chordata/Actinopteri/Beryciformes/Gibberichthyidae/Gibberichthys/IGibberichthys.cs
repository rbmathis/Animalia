namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Gibberichthyidae.Gibberichthys;

/// <summary>
/// Interface defining characteristics of Gibberichthys (genus).
/// </summary>
public interface IGibberichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
