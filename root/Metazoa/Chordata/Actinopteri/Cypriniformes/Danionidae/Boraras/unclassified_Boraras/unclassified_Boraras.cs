using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Boraras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Boraras.unclassified_Boraras;

/// <summary>
/// Abstract class for unclassified Boraras (no rank).
/// NCBI TaxId: 2620039
/// </summary>
public abstract class unclassified_Boraras : Boraras, Iunclassified_Boraras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boraras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620039;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boraras";
}
