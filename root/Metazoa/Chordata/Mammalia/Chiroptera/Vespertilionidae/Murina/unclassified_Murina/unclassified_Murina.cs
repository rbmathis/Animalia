using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Murina;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Murina.unclassified_Murina;

/// <summary>
/// Abstract class for unclassified Murina (no rank).
/// NCBI TaxId: 2685208
/// </summary>
public abstract class unclassified_Murina : Murina, Iunclassified_Murina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Murina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685208;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Murina";
}
