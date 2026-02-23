using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiotriccus;

/// <summary>
/// Abstract class for Myiotriccus (genus).
/// NCBI TaxId: 360219
/// </summary>
public abstract class Myiotriccus : Tyrannidae, IMyiotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360219;

    /// <inheritdoc />
    public virtual string GenusName => "Myiotriccus";

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
