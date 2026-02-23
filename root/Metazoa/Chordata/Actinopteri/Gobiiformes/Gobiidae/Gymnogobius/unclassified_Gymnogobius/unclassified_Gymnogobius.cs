using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gymnogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gymnogobius.unclassified_Gymnogobius;

/// <summary>
/// Abstract class for unclassified Gymnogobius (no rank).
/// NCBI TaxId: 2629390
/// </summary>
public abstract class unclassified_Gymnogobius : Gymnogobius, Iunclassified_Gymnogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629390;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnogobius";
}
