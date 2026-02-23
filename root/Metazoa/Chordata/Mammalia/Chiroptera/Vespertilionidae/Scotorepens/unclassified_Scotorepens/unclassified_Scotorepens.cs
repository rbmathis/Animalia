using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotorepens;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotorepens.unclassified_Scotorepens;

/// <summary>
/// Abstract class for unclassified Scotorepens (no rank).
/// NCBI TaxId: 2636263
/// </summary>
public abstract class unclassified_Scotorepens : Scotorepens, Iunclassified_Scotorepens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scotorepens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636263;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scotorepens";
}
