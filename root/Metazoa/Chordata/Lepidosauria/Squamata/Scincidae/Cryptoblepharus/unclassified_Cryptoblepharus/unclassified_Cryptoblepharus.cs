using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cryptoblepharus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cryptoblepharus.unclassified_Cryptoblepharus;

/// <summary>
/// Abstract class for unclassified Cryptoblepharus (no rank).
/// NCBI TaxId: 2630056
/// </summary>
public abstract class unclassified_Cryptoblepharus : Cryptoblepharus, Iunclassified_Cryptoblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptoblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630056;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptoblepharus";
}
