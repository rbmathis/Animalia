namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Lophodytes;

/// <summary>
/// Interface defining characteristics of Lophodytes (genus).
/// </summary>
public interface ILophodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
