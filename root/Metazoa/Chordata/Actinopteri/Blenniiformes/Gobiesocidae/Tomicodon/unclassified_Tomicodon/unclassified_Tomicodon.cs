using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Tomicodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Tomicodon.unclassified_Tomicodon;

/// <summary>
/// Abstract class for unclassified Tomicodon (no rank).
/// NCBI TaxId: 2632853
/// </summary>
public abstract class unclassified_Tomicodon : Tomicodon, Iunclassified_Tomicodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tomicodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632853;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tomicodon";
}
