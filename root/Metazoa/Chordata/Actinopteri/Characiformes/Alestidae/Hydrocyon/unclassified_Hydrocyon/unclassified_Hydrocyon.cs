using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocyon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocyon.unclassified_Hydrocyon;

/// <summary>
/// Abstract class for unclassified Hydrocyon (no rank).
/// NCBI TaxId: 2626816
/// </summary>
public abstract class unclassified_Hydrocyon : Hydrocyon, Iunclassified_Hydrocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydrocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626816;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydrocyon";
}
