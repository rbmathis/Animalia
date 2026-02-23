using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Dionda;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Dionda.unclassified_Dionda;

/// <summary>
/// Abstract class for unclassified Dionda (no rank).
/// NCBI TaxId: 2622656
/// </summary>
public abstract class unclassified_Dionda : Dionda, Iunclassified_Dionda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dionda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622656;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dionda";
}
