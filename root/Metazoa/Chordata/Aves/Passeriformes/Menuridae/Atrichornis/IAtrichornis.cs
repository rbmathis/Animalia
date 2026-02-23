namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae.Atrichornis;

/// <summary>
/// Interface defining characteristics of Atrichornis (genus).
/// </summary>
public interface IAtrichornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
