using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Xenophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Xenophrys.unclassified_Xenophrys;

/// <summary>
/// Abstract class for unclassified Xenophrys (no rank).
/// NCBI TaxId: 2617779
/// </summary>
public abstract class unclassified_Xenophrys : Xenophrys, Iunclassified_Xenophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenophrys";
}
