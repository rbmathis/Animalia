using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Lepophidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Lepophidium.unclassified_Lepophidium;

/// <summary>
/// Abstract class for unclassified Lepophidium (no rank).
/// NCBI TaxId: 3456245
/// </summary>
public abstract class unclassified_Lepophidium : Lepophidium, Iunclassified_Lepophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3456245;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepophidium";
}
