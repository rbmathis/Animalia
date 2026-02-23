namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anseranatidae.Anseranas;

/// <summary>
/// Interface defining characteristics of Anseranas (genus).
/// </summary>
public interface IAnseranas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
