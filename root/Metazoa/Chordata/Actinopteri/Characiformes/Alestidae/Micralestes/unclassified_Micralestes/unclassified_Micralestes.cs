using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Micralestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Micralestes.unclassified_Micralestes;

/// <summary>
/// Abstract class for unclassified Micralestes (no rank).
/// NCBI TaxId: 2639421
/// </summary>
public abstract class unclassified_Micralestes : Micralestes, Iunclassified_Micralestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micralestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micralestes";
}
