namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Chalcoparia;

/// <summary>
/// Interface defining characteristics of Chalcoparia (genus).
/// </summary>
public interface IChalcoparia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
