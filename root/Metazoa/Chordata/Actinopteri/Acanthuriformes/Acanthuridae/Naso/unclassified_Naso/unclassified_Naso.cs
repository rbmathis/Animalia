using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Naso;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Naso.unclassified_Naso;

/// <summary>
/// Abstract class for unclassified Naso (no rank).
/// NCBI TaxId: 2634390
/// </summary>
public abstract class unclassified_Naso : Naso, Iunclassified_Naso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Naso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634390;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Naso";
}
