using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Barilius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Barilius.unclassified_Barilius;

/// <summary>
/// Abstract class for unclassified Barilius (no rank).
/// NCBI TaxId: 2617876
/// </summary>
public abstract class unclassified_Barilius : Barilius, Iunclassified_Barilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617876;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barilius";
}
