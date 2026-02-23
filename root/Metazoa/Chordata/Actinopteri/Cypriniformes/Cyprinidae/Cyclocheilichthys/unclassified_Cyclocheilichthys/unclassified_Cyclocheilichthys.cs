using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyclocheilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyclocheilichthys.unclassified_Cyclocheilichthys;

/// <summary>
/// Abstract class for unclassified Cyclocheilichthys (no rank).
/// NCBI TaxId: 2621101
/// </summary>
public abstract class unclassified_Cyclocheilichthys : Cyclocheilichthys, Iunclassified_Cyclocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621101;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclocheilichthys";
}
