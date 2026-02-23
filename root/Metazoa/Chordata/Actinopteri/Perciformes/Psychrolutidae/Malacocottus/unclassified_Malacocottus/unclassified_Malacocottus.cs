using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Malacocottus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Malacocottus.unclassified_Malacocottus;

/// <summary>
/// Abstract class for unclassified Malacocottus (no rank).
/// NCBI TaxId: 2643322
/// </summary>
public abstract class unclassified_Malacocottus : Malacocottus, Iunclassified_Malacocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Malacocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643322;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Malacocottus";
}
