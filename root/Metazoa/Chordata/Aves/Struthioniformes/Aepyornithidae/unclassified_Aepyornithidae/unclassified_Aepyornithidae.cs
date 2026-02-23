using AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.unclassified_Aepyornithidae;

/// <summary>
/// Abstract class for unclassified Aepyornithidae (no rank).
/// NCBI TaxId: 2978696
/// </summary>
public abstract class unclassified_Aepyornithidae : Aepyornithidae, Iunclassified_Aepyornithidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aepyornithidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2978696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aepyornithidae";
}
