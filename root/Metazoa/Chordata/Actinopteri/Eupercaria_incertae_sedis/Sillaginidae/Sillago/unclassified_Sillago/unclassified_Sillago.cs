using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillago;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillago.unclassified_Sillago;

/// <summary>
/// Abstract class for unclassified Sillago (no rank).
/// NCBI TaxId: 2609521
/// </summary>
public abstract class unclassified_Sillago : Sillago, Iunclassified_Sillago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sillago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sillago";
}
