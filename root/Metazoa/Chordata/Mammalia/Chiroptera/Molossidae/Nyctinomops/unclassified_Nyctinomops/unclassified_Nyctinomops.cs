using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Nyctinomops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Nyctinomops.unclassified_Nyctinomops;

/// <summary>
/// Abstract class for unclassified Nyctinomops (no rank).
/// NCBI TaxId: 2968822
/// </summary>
public abstract class unclassified_Nyctinomops : Nyctinomops, Iunclassified_Nyctinomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctinomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2968822;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctinomops";
}
