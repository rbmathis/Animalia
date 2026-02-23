using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapidae_incertae_sedis;

/// <summary>
/// Abstract class for Elapidae incertae sedis (no rank).
/// NCBI TaxId: 3410199
/// </summary>
public abstract class Elapidae_incertae_sedis : Elapidae, IElapidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elapidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410199;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Elapidae_incertae_sedis";
}
