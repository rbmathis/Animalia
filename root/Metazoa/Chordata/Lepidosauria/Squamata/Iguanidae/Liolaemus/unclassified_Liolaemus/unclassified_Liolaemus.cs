using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus.unclassified_Liolaemus;

/// <summary>
/// Abstract class for unclassified Liolaemus (no rank).
/// NCBI TaxId: 221459
/// </summary>
public abstract class unclassified_Liolaemus : Liolaemus, Iunclassified_Liolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221459;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liolaemus";
}
