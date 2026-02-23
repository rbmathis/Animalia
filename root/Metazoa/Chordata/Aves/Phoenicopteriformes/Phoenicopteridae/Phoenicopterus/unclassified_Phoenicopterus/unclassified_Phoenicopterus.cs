using AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicopterus.unclassified_Phoenicopterus;

/// <summary>
/// Abstract class for unclassified Phoenicopterus (no rank).
/// NCBI TaxId: 3467920
/// </summary>
public abstract class unclassified_Phoenicopterus : Phoenicopterus, Iunclassified_Phoenicopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phoenicopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phoenicopterus";
}
