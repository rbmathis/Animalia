using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Elgaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Elgaria.unclassified_Elgaria;

/// <summary>
/// Abstract class for unclassified Elgaria (no rank).
/// NCBI TaxId: 2878419
/// </summary>
public abstract class unclassified_Elgaria : Elgaria, Iunclassified_Elgaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elgaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878419;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elgaria";
}
