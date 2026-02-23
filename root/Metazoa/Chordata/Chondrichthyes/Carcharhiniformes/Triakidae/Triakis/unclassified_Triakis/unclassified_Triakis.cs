using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis.unclassified_Triakis;

/// <summary>
/// Abstract class for unclassified Triakis (no rank).
/// NCBI TaxId: 2642359
/// </summary>
public abstract class unclassified_Triakis : Triakis, Iunclassified_Triakis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triakis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642359;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triakis";
}
