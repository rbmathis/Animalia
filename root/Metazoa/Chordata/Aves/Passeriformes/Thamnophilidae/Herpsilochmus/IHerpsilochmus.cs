namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Herpsilochmus;

/// <summary>
/// Interface defining characteristics of Herpsilochmus (genus).
/// </summary>
public interface IHerpsilochmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
