using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danionella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danionella.unclassified_Danionella;

/// <summary>
/// Abstract class for unclassified Danionella (no rank).
/// NCBI TaxId: 2646035
/// </summary>
public abstract class unclassified_Danionella : Danionella, Iunclassified_Danionella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Danionella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646035;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Danionella";
}
