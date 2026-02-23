namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Devioeca;

/// <summary>
/// Interface defining characteristics of Devioeca (genus).
/// </summary>
public interface IDevioeca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
