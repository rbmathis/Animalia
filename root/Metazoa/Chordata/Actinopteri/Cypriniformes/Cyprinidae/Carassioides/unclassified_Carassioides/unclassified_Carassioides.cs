using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassioides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassioides.unclassified_Carassioides;

/// <summary>
/// Abstract class for unclassified Carassioides (no rank).
/// NCBI TaxId: 2620936
/// </summary>
public abstract class unclassified_Carassioides : Carassioides, Iunclassified_Carassioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carassioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carassioides";
}
