using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Zacco;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Zacco.unclassified_Zacco;

/// <summary>
/// Abstract class for unclassified Zacco (no rank).
/// NCBI TaxId: 2632240
/// </summary>
public abstract class unclassified_Zacco : Zacco, Iunclassified_Zacco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zacco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632240;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zacco";
}
