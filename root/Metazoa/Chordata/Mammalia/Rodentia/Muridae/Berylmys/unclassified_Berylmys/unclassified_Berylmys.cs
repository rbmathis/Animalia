using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys.unclassified_Berylmys;

/// <summary>
/// Abstract class for unclassified Berylmys (no rank).
/// NCBI TaxId: 2640464
/// </summary>
public abstract class unclassified_Berylmys : Berylmys, Iunclassified_Berylmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Berylmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640464;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Berylmys";
}
