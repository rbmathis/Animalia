using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Benthophilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Benthophilus.unclassified_Benthophilus;

/// <summary>
/// Abstract class for unclassified Benthophilus (no rank).
/// NCBI TaxId: 2637780
/// </summary>
public abstract class unclassified_Benthophilus : Benthophilus, Iunclassified_Benthophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Benthophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637780;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Benthophilus";
}
