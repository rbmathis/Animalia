namespace AnimalKingdom.root.Metazoa.Chordata.Coelacanthiformes.Coelacanthidae.Latimeria;

/// <summary>
/// Interface defining characteristics of Latimeria (genus).
/// </summary>
public interface ILatimeria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
