namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cnemiornis;

/// <summary>
/// Interface defining characteristics of Cnemiornis (genus).
/// </summary>
public interface ICnemiornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
