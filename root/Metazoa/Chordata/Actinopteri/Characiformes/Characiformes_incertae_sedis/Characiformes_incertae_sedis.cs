using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characiformes_incertae_sedis;

/// <summary>
/// Abstract class for Characiformes incertae sedis (no rank).
/// NCBI TaxId: 2283321
/// </summary>
public abstract class Characiformes_incertae_sedis : Characiformes, ICharaciformes_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Characiformes incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2283321;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Characiformes_incertae_sedis";
}
