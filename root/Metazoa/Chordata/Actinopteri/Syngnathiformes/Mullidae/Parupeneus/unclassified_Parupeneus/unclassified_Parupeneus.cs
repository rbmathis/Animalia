using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Parupeneus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Parupeneus.unclassified_Parupeneus;

/// <summary>
/// Abstract class for unclassified Parupeneus (no rank).
/// NCBI TaxId: 2647658
/// </summary>
public abstract class unclassified_Parupeneus : Parupeneus, Iunclassified_Parupeneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parupeneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647658;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parupeneus";
}
