using AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Aepyornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Aepyornis.unclassified_Aepyornis;

/// <summary>
/// Abstract class for unclassified Aepyornis (no rank).
/// NCBI TaxId: 2630318
/// </summary>
public abstract class unclassified_Aepyornis : Aepyornis, Iunclassified_Aepyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aepyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630318;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aepyornis";
}
