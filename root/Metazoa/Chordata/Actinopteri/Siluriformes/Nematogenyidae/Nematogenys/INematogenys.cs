namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Nematogenyidae.Nematogenys;

/// <summary>
/// Interface defining characteristics of Nematogenys (genus).
/// </summary>
public interface INematogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
