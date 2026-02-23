using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus.unclassified_Hoplobatrachus;

/// <summary>
/// Abstract class for unclassified Hoplobatrachus (no rank).
/// NCBI TaxId: 2787090
/// </summary>
public abstract class unclassified_Hoplobatrachus : Hoplobatrachus, Iunclassified_Hoplobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2787090;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplobatrachus";
}
