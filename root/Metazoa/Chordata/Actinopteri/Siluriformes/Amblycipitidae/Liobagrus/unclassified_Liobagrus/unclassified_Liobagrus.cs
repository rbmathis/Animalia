using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Liobagrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Liobagrus.unclassified_Liobagrus;

/// <summary>
/// Abstract class for unclassified Liobagrus (no rank).
/// NCBI TaxId: 2630371
/// </summary>
public abstract class unclassified_Liobagrus : Liobagrus, Iunclassified_Liobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630371;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liobagrus";
}
