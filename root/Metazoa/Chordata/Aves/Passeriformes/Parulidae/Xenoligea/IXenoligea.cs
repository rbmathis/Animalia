namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Xenoligea;

/// <summary>
/// Interface defining characteristics of Xenoligea (genus).
/// </summary>
public interface IXenoligea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
