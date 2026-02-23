using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Zosterops;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Zosterops.unclassified_Zosterops;

/// <summary>
/// Abstract class for unclassified Zosterops (no rank).
/// NCBI TaxId: 2632467
/// </summary>
public abstract class unclassified_Zosterops : Zosterops, Iunclassified_Zosterops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zosterops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632467;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zosterops";
}
