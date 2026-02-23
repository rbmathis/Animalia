namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae.Chaudhuria;

/// <summary>
/// Interface defining characteristics of Chaudhuria (genus).
/// </summary>
public interface IChaudhuria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
