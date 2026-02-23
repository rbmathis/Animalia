namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae.Pillaia;

/// <summary>
/// Interface defining characteristics of Pillaia (genus).
/// </summary>
public interface IPillaia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
