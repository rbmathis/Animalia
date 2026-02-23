using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Stephanolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Stephanolepis.unclassified_Stephanolepis;

/// <summary>
/// Abstract class for unclassified Stephanolepis (no rank).
/// NCBI TaxId: 2622614
/// </summary>
public abstract class unclassified_Stephanolepis : Stephanolepis, Iunclassified_Stephanolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stephanolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622614;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stephanolepis";
}
