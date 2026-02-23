using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Eurycheilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Eurycheilichthys.unclassified_Eurycheilichthys;

/// <summary>
/// Abstract class for unclassified Eurycheilichthys (no rank).
/// NCBI TaxId: 2636509
/// </summary>
public abstract class unclassified_Eurycheilichthys : Eurycheilichthys, Iunclassified_Eurycheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurycheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636509;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurycheilichthys";
}
