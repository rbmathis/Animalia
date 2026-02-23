using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae.Dinornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae.Dinornis.unclassified_Dinornis;

/// <summary>
/// Abstract class for unclassified Dinornis (no rank).
/// NCBI TaxId: 2677264
/// </summary>
public abstract class unclassified_Dinornis : Dinornis, Iunclassified_Dinornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dinornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677264;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dinornis";
}
