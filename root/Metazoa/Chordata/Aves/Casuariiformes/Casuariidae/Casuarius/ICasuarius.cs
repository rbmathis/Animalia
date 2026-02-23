namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae.Casuarius;

/// <summary>
/// Interface defining characteristics of Casuarius (genus).
/// </summary>
public interface ICasuarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
