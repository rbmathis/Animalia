using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Urophycis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Urophycis.unclassified_Urophycis;

/// <summary>
/// Abstract class for unclassified Urophycis (no rank).
/// NCBI TaxId: 2910021
/// </summary>
public abstract class unclassified_Urophycis : Urophycis, Iunclassified_Urophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Urophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2910021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Urophycis";
}
