using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Taeniotriccus;

/// <summary>
/// Abstract class for Taeniotriccus (genus).
/// NCBI TaxId: 649817
/// </summary>
public abstract class Taeniotriccus : Tyrannidae, ITaeniotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649817;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniotriccus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
