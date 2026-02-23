using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Sarcocheilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Sarcocheilichthys.unclassified_Sarcocheilichthys;

/// <summary>
/// Abstract class for unclassified Sarcocheilichthys (no rank).
/// NCBI TaxId: 2725762
/// </summary>
public abstract class unclassified_Sarcocheilichthys : Sarcocheilichthys, Iunclassified_Sarcocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sarcocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2725762;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sarcocheilichthys";
}
