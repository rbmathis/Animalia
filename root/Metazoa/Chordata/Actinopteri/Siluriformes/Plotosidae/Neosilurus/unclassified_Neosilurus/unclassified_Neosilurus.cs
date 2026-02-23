using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Neosilurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Neosilurus.unclassified_Neosilurus;

/// <summary>
/// Abstract class for unclassified Neosilurus (no rank).
/// NCBI TaxId: 2850009
/// </summary>
public abstract class unclassified_Neosilurus : Neosilurus, Iunclassified_Neosilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neosilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2850009;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neosilurus";
}
