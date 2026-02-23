using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Eumops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Eumops.unclassified_Eumops;

/// <summary>
/// Abstract class for unclassified Eumops (no rank).
/// NCBI TaxId: 2619363
/// </summary>
public abstract class unclassified_Eumops : Eumops, Iunclassified_Eumops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eumops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619363;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eumops";
}
