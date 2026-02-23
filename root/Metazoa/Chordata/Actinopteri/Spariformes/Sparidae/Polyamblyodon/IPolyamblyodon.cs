namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Polyamblyodon;

/// <summary>
/// Interface defining characteristics of Polyamblyodon (genus).
/// </summary>
public interface IPolyamblyodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
