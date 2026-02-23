using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Parapriacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Parapriacanthus.unclassified_Parapriacanthus;

/// <summary>
/// Abstract class for unclassified Parapriacanthus (no rank).
/// NCBI TaxId: 2989988
/// </summary>
public abstract class unclassified_Parapriacanthus : Parapriacanthus, Iunclassified_Parapriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parapriacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989988;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parapriacanthus";
}
