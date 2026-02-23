using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tariqilabeo;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tariqilabeo.unclassified_Tariqilabeo;

/// <summary>
/// Abstract class for unclassified Tariqilabeo (no rank).
/// NCBI TaxId: 2787638
/// </summary>
public abstract class unclassified_Tariqilabeo : Tariqilabeo, Iunclassified_Tariqilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tariqilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2787638;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tariqilabeo";
}
