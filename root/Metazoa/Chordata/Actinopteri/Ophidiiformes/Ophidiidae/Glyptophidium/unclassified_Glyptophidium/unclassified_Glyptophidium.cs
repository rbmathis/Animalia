using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Glyptophidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Glyptophidium.unclassified_Glyptophidium;

/// <summary>
/// Abstract class for unclassified Glyptophidium (no rank).
/// NCBI TaxId: 2800631
/// </summary>
public abstract class unclassified_Glyptophidium : Glyptophidium, Iunclassified_Glyptophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyptophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2800631;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyptophidium";
}
