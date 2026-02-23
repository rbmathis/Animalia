namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Eutrichomyias;

/// <summary>
/// Interface defining characteristics of Eutrichomyias (genus).
/// </summary>
public interface IEutrichomyias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
