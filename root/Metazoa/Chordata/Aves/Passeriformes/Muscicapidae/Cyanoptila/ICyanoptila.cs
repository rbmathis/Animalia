namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyanoptila;

/// <summary>
/// Interface defining characteristics of Cyanoptila (genus).
/// </summary>
public interface ICyanoptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
