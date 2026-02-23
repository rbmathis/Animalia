using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis.unclassified_Chelonoidis;

/// <summary>
/// Abstract class for unclassified Chelonoidis (no rank).
/// NCBI TaxId: 2619869
/// </summary>
public abstract class unclassified_Chelonoidis : Chelonoidis, Iunclassified_Chelonoidis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chelonoidis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chelonoidis";
}
