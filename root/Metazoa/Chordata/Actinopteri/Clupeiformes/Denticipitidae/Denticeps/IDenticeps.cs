namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Denticipitidae.Denticeps;

/// <summary>
/// Interface defining characteristics of Denticeps (genus).
/// </summary>
public interface IDenticeps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
