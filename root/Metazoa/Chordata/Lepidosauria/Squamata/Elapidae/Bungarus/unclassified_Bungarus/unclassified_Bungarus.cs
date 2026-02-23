using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Bungarus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Bungarus.unclassified_Bungarus;

/// <summary>
/// Abstract class for unclassified Bungarus (no rank).
/// NCBI TaxId: 2726461
/// </summary>
public abstract class unclassified_Bungarus : Bungarus, Iunclassified_Bungarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bungarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726461;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bungarus";
}
