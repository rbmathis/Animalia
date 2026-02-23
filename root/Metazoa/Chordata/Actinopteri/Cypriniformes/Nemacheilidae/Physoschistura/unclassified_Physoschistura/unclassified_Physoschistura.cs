using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Physoschistura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Physoschistura.unclassified_Physoschistura;

/// <summary>
/// Abstract class for unclassified Physoschistura (no rank).
/// NCBI TaxId: 2646135
/// </summary>
public abstract class unclassified_Physoschistura : Physoschistura, Iunclassified_Physoschistura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Physoschistura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646135;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Physoschistura";
}
