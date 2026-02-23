namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Helopsaltes;

/// <summary>
/// Interface defining characteristics of Helopsaltes (genus).
/// </summary>
public interface IHelopsaltes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
