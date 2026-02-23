using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Schismatogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Schismatogobius.unclassified_Schismatogobius;

/// <summary>
/// Abstract class for unclassified Schismatogobius (no rank).
/// NCBI TaxId: 2639355
/// </summary>
public abstract class unclassified_Schismatogobius : Schismatogobius, Iunclassified_Schismatogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schismatogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639355;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schismatogobius";
}
