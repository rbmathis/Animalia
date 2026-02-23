namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Grammonus;

/// <summary>
/// Interface defining characteristics of Grammonus (genus).
/// </summary>
public interface IGrammonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
