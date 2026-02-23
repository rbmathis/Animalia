using AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelomedusa.unclassified_Pelomedusa;

/// <summary>
/// Abstract class for unclassified Pelomedusa (no rank).
/// NCBI TaxId: 2622671
/// </summary>
public abstract class unclassified_Pelomedusa : Pelomedusa, Iunclassified_Pelomedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelomedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622671;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelomedusa";
}
