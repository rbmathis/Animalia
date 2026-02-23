namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Lioptilus;

/// <summary>
/// Interface defining characteristics of Lioptilus (genus).
/// </summary>
public interface ILioptilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
