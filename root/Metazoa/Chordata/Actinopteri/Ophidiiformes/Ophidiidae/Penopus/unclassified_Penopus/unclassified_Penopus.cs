using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Penopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Penopus.unclassified_Penopus;

/// <summary>
/// Abstract class for unclassified Penopus (no rank).
/// NCBI TaxId: 3448521
/// </summary>
public abstract class unclassified_Penopus : Penopus, Iunclassified_Penopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Penopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3448521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Penopus";
}
