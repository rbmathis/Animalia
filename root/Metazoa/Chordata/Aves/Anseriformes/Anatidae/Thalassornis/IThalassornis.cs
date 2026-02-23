namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Thalassornis;

/// <summary>
/// Interface defining characteristics of Thalassornis (genus).
/// </summary>
public interface IThalassornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
