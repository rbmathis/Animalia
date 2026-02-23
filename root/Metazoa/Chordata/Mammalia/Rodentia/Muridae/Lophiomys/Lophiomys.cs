using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophiomys;

/// <summary>
/// Abstract class for Lophiomys (genus).
/// NCBI TaxId: 248798
/// </summary>
public abstract class Lophiomys : Muridae, ILophiomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248798;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiomys";

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
