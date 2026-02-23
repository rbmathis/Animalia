using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carasobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carasobarbus.unclassified_Carasobarbus;

/// <summary>
/// Abstract class for unclassified Carasobarbus (no rank).
/// NCBI TaxId: 2644788
/// </summary>
public abstract class unclassified_Carasobarbus : Carasobarbus, Iunclassified_Carasobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carasobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carasobarbus";
}
