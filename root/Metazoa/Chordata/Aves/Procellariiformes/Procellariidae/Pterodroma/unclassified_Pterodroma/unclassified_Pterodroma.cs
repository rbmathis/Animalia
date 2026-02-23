using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pterodroma;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pterodroma.unclassified_Pterodroma;

/// <summary>
/// Abstract class for unclassified Pterodroma (no rank).
/// NCBI TaxId: 2642237
/// </summary>
public abstract class unclassified_Pterodroma : Pterodroma, Iunclassified_Pterodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642237;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterodroma";
}
