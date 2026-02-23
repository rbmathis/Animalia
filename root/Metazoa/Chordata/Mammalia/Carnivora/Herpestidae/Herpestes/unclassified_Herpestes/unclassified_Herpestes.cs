using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes.unclassified_Herpestes;

/// <summary>
/// Abstract class for unclassified Herpestes (no rank).
/// NCBI TaxId: 3088347
/// </summary>
public abstract class unclassified_Herpestes : Herpestes, Iunclassified_Herpestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Herpestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3088347;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Herpestes";
}
