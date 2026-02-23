using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Padogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Padogobius.unclassified_Padogobius;

/// <summary>
/// Abstract class for unclassified Padogobius (no rank).
/// NCBI TaxId: 3472374
/// </summary>
public abstract class unclassified_Padogobius : Padogobius, Iunclassified_Padogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Padogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3472374;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Padogobius";
}
