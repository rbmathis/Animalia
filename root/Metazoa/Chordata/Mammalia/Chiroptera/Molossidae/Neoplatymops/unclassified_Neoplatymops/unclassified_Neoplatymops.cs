using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Neoplatymops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Neoplatymops.unclassified_Neoplatymops;

/// <summary>
/// Abstract class for unclassified Neoplatymops (no rank).
/// NCBI TaxId: 3111556
/// </summary>
public abstract class unclassified_Neoplatymops : Neoplatymops, Iunclassified_Neoplatymops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoplatymops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111556;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoplatymops";
}
