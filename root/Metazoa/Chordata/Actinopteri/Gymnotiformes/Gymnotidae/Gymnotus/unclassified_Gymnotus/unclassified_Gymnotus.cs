using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Gymnotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Gymnotus.unclassified_Gymnotus;

/// <summary>
/// Abstract class for unclassified Gymnotus (no rank).
/// NCBI TaxId: 2630444
/// </summary>
public abstract class unclassified_Gymnotus : Gymnotus, Iunclassified_Gymnotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630444;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnotus";
}
