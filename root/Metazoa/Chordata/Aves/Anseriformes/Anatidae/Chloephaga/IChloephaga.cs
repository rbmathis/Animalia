namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Chloephaga;

/// <summary>
/// Interface defining characteristics of Chloephaga (genus).
/// </summary>
public interface IChloephaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
