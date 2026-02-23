namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Dermogenys;

/// <summary>
/// Interface defining characteristics of Dermogenys (genus).
/// </summary>
public interface IDermogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
