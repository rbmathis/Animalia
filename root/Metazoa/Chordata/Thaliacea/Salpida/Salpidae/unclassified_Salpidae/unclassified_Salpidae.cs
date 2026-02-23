using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.unclassified_Salpidae;

/// <summary>
/// Abstract class for unclassified Salpidae (no rank).
/// NCBI TaxId: 942557
/// </summary>
public abstract class unclassified_Salpidae : Salpidae, Iunclassified_Salpidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salpidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942557;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salpidae";
}
