using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.hybrid_Heroini_sp;

/// <summary>
/// Abstract class for hybrid Heroini sp. (no rank).
/// NCBI TaxId: 762615
/// </summary>
public abstract class hybrid_Heroini_sp : Cichlidae, Ihybrid_Heroini_sp
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "hybrid Heroini sp.";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 762615;

    /// <inheritdoc />
    public virtual string Description => "Taxon: hybrid_Heroini_sp";
}
