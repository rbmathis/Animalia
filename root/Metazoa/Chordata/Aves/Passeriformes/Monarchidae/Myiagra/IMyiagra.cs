namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Myiagra;

/// <summary>
/// Interface defining characteristics of Myiagra (genus).
/// </summary>
public interface IMyiagra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
