using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagridae_hybrid_sp;

/// <summary>
/// Abstract class for Bagridae hybrid sp. (unknown).
/// NCBI TaxId: 1867947
/// </summary>
public abstract class Bagridae_hybrid_sp : Bagridae, IBagridae_hybrid_sp
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagridae hybrid sp.";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "unknown";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1867947;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Bagridae_hybrid_sp";
}
