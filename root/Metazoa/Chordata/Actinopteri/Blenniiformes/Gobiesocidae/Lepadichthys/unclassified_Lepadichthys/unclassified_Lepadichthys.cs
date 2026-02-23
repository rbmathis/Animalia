using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Lepadichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Lepadichthys.unclassified_Lepadichthys;

/// <summary>
/// Abstract class for unclassified Lepadichthys (no rank).
/// NCBI TaxId: 3444683
/// </summary>
public abstract class unclassified_Lepadichthys : Lepadichthys, Iunclassified_Lepadichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepadichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444683;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepadichthys";
}
