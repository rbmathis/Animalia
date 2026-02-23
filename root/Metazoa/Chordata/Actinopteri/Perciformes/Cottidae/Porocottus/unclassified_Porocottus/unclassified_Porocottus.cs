using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Porocottus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Porocottus.unclassified_Porocottus;

/// <summary>
/// Abstract class for unclassified Porocottus (no rank).
/// NCBI TaxId: 2625684
/// </summary>
public abstract class unclassified_Porocottus : Porocottus, Iunclassified_Porocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Porocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625684;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Porocottus";
}
