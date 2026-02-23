namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Cephalopyrus;

/// <summary>
/// Interface defining characteristics of Cephalopyrus (genus).
/// </summary>
public interface ICephalopyrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
