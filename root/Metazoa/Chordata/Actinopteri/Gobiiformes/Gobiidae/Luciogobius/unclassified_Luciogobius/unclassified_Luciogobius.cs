using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Luciogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Luciogobius.unclassified_Luciogobius;

/// <summary>
/// Abstract class for unclassified Luciogobius (no rank).
/// NCBI TaxId: 2630962
/// </summary>
public abstract class unclassified_Luciogobius : Luciogobius, Iunclassified_Luciogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciogobius";
}
