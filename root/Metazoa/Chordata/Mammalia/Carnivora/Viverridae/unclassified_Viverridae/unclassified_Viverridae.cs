using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.unclassified_Viverridae;

/// <summary>
/// Abstract class for unclassified Viverridae (no rank).
/// NCBI TaxId: 2980523
/// </summary>
public abstract class unclassified_Viverridae : Viverridae, Iunclassified_Viverridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Viverridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980523;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Viverridae";
}
