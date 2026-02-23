using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossops.unclassified_Molossops;

/// <summary>
/// Abstract class for unclassified Molossops (no rank).
/// NCBI TaxId: 2737245
/// </summary>
public abstract class unclassified_Molossops : Molossops, Iunclassified_Molossops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Molossops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2737245;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Molossops";
}
