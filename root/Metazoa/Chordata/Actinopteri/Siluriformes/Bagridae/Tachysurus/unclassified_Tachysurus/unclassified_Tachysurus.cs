using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Tachysurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Tachysurus.unclassified_Tachysurus;

/// <summary>
/// Abstract class for unclassified Tachysurus (no rank).
/// NCBI TaxId: 2632454
/// </summary>
public abstract class unclassified_Tachysurus : Tachysurus, Iunclassified_Tachysurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tachysurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tachysurus";
}
