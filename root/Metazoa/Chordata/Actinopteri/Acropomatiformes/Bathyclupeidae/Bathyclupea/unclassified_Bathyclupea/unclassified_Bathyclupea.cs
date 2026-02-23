using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae.Bathyclupea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae.Bathyclupea.unclassified_Bathyclupea;

/// <summary>
/// Abstract class for unclassified Bathyclupea (no rank).
/// NCBI TaxId: 2632103
/// </summary>
public abstract class unclassified_Bathyclupea : Bathyclupea, Iunclassified_Bathyclupea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyclupea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632103;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyclupea";
}
