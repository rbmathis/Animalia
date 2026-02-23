using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Redigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Redigobius.unclassified_Redigobius;

/// <summary>
/// Abstract class for unclassified Redigobius (no rank).
/// NCBI TaxId: 2636532
/// </summary>
public abstract class unclassified_Redigobius : Redigobius, Iunclassified_Redigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Redigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636532;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Redigobius";
}
