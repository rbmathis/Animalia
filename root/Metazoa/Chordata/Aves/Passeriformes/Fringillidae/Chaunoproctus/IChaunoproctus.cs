namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chaunoproctus;

/// <summary>
/// Interface defining characteristics of Chaunoproctus (genus).
/// </summary>
public interface IChaunoproctus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
