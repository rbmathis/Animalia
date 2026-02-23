using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Promops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Promops.unclassified_Promops;

/// <summary>
/// Abstract class for unclassified Promops (no rank).
/// NCBI TaxId: 2907245
/// </summary>
public abstract class unclassified_Promops : Promops, Iunclassified_Promops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Promops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2907245;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Promops";
}
