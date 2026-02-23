using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Semaprochilodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Semaprochilodus.unclassified_Semaprochilodus;

/// <summary>
/// Abstract class for unclassified Semaprochilodus (no rank).
/// NCBI TaxId: 2636032
/// </summary>
public abstract class unclassified_Semaprochilodus : Semaprochilodus, Iunclassified_Semaprochilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Semaprochilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636032;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Semaprochilodus";
}
