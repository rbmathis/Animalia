using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Ictiobus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Ictiobus.unclassified_Ictiobus;

/// <summary>
/// Abstract class for unclassified Ictiobus (no rank).
/// NCBI TaxId: 2644202
/// </summary>
public abstract class unclassified_Ictiobus : Ictiobus, Iunclassified_Ictiobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ictiobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644202;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ictiobus";
}
