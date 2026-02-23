using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Megascops;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Megascops.unclassified_Megascops;

/// <summary>
/// Abstract class for unclassified Megascops (no rank).
/// NCBI TaxId: 2629370
/// </summary>
public abstract class unclassified_Megascops : Megascops, Iunclassified_Megascops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megascops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629370;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megascops";
}
