using AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Mullerornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Mullerornis.unclassified_Mullerornis;

/// <summary>
/// Abstract class for unclassified Mullerornis (no rank).
/// NCBI TaxId: 2636754
/// </summary>
public abstract class unclassified_Mullerornis : Mullerornis, Iunclassified_Mullerornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mullerornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636754;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mullerornis";
}
