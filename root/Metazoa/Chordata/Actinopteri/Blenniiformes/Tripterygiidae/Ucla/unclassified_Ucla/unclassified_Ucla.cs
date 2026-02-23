using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Ucla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Ucla.unclassified_Ucla;

/// <summary>
/// Abstract class for unclassified Ucla (no rank).
/// NCBI TaxId: 2965541
/// </summary>
public abstract class unclassified_Ucla : Ucla, Iunclassified_Ucla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ucla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2965541;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ucla";
}
