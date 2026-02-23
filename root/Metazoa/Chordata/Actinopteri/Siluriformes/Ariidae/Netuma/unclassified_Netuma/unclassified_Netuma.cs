using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Netuma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Netuma.unclassified_Netuma;

/// <summary>
/// Abstract class for unclassified Netuma (no rank).
/// NCBI TaxId: 2641576
/// </summary>
public abstract class unclassified_Netuma : Netuma, Iunclassified_Netuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Netuma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641576;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Netuma";
}
