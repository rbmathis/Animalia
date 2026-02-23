using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Papuligobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Papuligobius.unclassified_Papuligobius;

/// <summary>
/// Abstract class for unclassified Papuligobius (no rank).
/// NCBI TaxId: 3446502
/// </summary>
public abstract class unclassified_Papuligobius : Papuligobius, Iunclassified_Papuligobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Papuligobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446502;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Papuligobius";
}
