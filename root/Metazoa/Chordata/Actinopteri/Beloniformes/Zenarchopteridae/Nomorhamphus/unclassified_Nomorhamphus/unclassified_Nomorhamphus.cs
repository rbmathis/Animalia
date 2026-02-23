using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Nomorhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Nomorhamphus.unclassified_Nomorhamphus;

/// <summary>
/// Abstract class for unclassified Nomorhamphus (no rank).
/// NCBI TaxId: 2636247
/// </summary>
public abstract class unclassified_Nomorhamphus : Nomorhamphus, Iunclassified_Nomorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nomorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636247;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nomorhamphus";
}
