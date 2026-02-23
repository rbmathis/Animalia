namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myioborus;

/// <summary>
/// Interface defining characteristics of Myioborus (genus).
/// </summary>
public interface IMyioborus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
