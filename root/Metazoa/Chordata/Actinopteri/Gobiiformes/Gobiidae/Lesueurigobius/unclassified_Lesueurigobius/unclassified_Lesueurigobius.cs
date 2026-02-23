using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lesueurigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lesueurigobius.unclassified_Lesueurigobius;

/// <summary>
/// Abstract class for unclassified Lesueurigobius (no rank).
/// NCBI TaxId: 2629704
/// </summary>
public abstract class unclassified_Lesueurigobius : Lesueurigobius, Iunclassified_Lesueurigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lesueurigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629704;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lesueurigobius";
}
