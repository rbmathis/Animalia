using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Rita;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Rita.unclassified_Rita;

/// <summary>
/// Abstract class for unclassified Rita (no rank).
/// NCBI TaxId: 2649414
/// </summary>
public abstract class unclassified_Rita : Rita, Iunclassified_Rita
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rita";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649414;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rita";
}
