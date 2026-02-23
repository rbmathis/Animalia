using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Dermogenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Dermogenys.unclassified_Dermogenys;

/// <summary>
/// Abstract class for unclassified Dermogenys (no rank).
/// NCBI TaxId: 2640248
/// </summary>
public abstract class unclassified_Dermogenys : Dermogenys, Iunclassified_Dermogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dermogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640248;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dermogenys";
}
