using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Asterropteryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Asterropteryx.unclassified_Asterropteryx;

/// <summary>
/// Abstract class for unclassified Asterropteryx (no rank).
/// NCBI TaxId: 2989916
/// </summary>
public abstract class unclassified_Asterropteryx : Asterropteryx, Iunclassified_Asterropteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asterropteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989916;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asterropteryx";
}
