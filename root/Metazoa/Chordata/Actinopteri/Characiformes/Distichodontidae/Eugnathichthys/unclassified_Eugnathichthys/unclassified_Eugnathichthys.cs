using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Eugnathichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Eugnathichthys.unclassified_Eugnathichthys;

/// <summary>
/// Abstract class for unclassified Eugnathichthys (no rank).
/// NCBI TaxId: 2631031
/// </summary>
public abstract class unclassified_Eugnathichthys : Eugnathichthys, Iunclassified_Eugnathichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eugnathichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eugnathichthys";
}
