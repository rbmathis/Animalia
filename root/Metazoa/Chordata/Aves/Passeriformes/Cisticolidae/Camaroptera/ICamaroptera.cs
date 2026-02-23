namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Camaroptera;

/// <summary>
/// Interface defining characteristics of Camaroptera (genus).
/// </summary>
public interface ICamaroptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
