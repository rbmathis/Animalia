using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Selachophidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Selachophidium.unclassified_Selachophidium;

/// <summary>
/// Abstract class for unclassified Selachophidium (no rank).
/// NCBI TaxId: 2622332
/// </summary>
public abstract class unclassified_Selachophidium : Selachophidium, Iunclassified_Selachophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Selachophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622332;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Selachophidium";
}
