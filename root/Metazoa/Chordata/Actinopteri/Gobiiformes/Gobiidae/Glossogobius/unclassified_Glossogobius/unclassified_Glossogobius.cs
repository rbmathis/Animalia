using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Glossogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Glossogobius.unclassified_Glossogobius;

/// <summary>
/// Abstract class for unclassified Glossogobius (no rank).
/// NCBI TaxId: 2625493
/// </summary>
public abstract class unclassified_Glossogobius : Glossogobius, Iunclassified_Glossogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glossogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625493;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glossogobius";
}
