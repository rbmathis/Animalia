using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Squalidus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Squalidus.unclassified_Squalidus;

/// <summary>
/// Abstract class for unclassified Squalidus (no rank).
/// NCBI TaxId: 2624250
/// </summary>
public abstract class unclassified_Squalidus : Squalidus, Iunclassified_Squalidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squalidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624250;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squalidus";
}
