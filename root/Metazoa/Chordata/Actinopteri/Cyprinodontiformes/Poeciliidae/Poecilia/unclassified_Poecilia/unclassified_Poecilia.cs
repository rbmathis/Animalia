using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poecilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Poecilia.unclassified_Poecilia;

/// <summary>
/// Abstract class for unclassified Poecilia (no rank).
/// NCBI TaxId: 2602681
/// </summary>
public abstract class unclassified_Poecilia : Poecilia, Iunclassified_Poecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602681;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poecilia";
}
