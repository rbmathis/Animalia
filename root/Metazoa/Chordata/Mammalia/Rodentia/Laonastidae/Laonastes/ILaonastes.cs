namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Laonastidae.Laonastes;

/// <summary>
/// Interface defining characteristics of Laonastes (genus).
/// </summary>
public interface ILaonastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
