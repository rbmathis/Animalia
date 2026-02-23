using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ameerega;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ameerega.unclassified_Ameerega;

/// <summary>
/// Abstract class for unclassified Ameerega (no rank).
/// NCBI TaxId: 2623120
/// </summary>
public abstract class unclassified_Ameerega : Ameerega, Iunclassified_Ameerega
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ameerega";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623120;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ameerega";
}
