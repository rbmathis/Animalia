using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus.Callionymus_incertae_sedis;

/// <summary>
/// Abstract class for Callionymus incertae sedis (no rank).
/// NCBI TaxId: 2608474
/// </summary>
public abstract class Callionymus_incertae_sedis : Callionymus, ICallionymus_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callionymus incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Callionymus_incertae_sedis";
}
