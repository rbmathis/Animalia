using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Gila;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Gila.unclassified_Gila;

/// <summary>
/// Abstract class for unclassified Gila (no rank).
/// NCBI TaxId: 2649462
/// </summary>
public abstract class unclassified_Gila : Gila, Iunclassified_Gila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649462;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gila";
}
