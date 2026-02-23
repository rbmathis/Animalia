namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Taeniotriccus;

/// <summary>
/// Interface defining characteristics of Taeniotriccus (genus).
/// </summary>
public interface ITaeniotriccus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
