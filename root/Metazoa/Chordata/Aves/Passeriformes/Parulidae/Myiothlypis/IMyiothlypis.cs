namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myiothlypis;

/// <summary>
/// Interface defining characteristics of Myiothlypis (genus).
/// </summary>
public interface IMyiothlypis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
