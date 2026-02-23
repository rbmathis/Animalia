namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Alectroenas;

/// <summary>
/// Interface defining characteristics of Alectroenas (genus).
/// </summary>
public interface IAlectroenas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
