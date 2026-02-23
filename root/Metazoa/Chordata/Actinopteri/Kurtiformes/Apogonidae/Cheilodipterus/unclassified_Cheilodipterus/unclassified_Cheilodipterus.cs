using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cheilodipterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cheilodipterus.unclassified_Cheilodipterus;

/// <summary>
/// Abstract class for unclassified Cheilodipterus (no rank).
/// NCBI TaxId: 2630571
/// </summary>
public abstract class unclassified_Cheilodipterus : Cheilodipterus, Iunclassified_Cheilodipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheilodipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630571;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheilodipterus";
}
