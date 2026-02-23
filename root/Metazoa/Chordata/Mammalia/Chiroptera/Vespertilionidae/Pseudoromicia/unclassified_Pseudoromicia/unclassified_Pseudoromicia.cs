using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pseudoromicia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pseudoromicia.unclassified_Pseudoromicia;

/// <summary>
/// Abstract class for unclassified Pseudoromicia (no rank).
/// NCBI TaxId: 2778575
/// </summary>
public abstract class unclassified_Pseudoromicia : Pseudoromicia, Iunclassified_Pseudoromicia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoromicia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2778575;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoromicia";
}
