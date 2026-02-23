namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae.Lampris;

/// <summary>
/// Interface defining characteristics of Lampris (genus).
/// </summary>
public interface ILampris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
