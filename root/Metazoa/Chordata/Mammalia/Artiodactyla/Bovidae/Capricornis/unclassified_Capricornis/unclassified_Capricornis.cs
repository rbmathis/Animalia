using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capricornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capricornis.unclassified_Capricornis;

/// <summary>
/// Abstract class for unclassified Capricornis (no rank).
/// NCBI TaxId: 2621394
/// </summary>
public abstract class unclassified_Capricornis : Capricornis, Iunclassified_Capricornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Capricornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621394;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Capricornis";
}
