using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis;

/// <summary>
/// Abstract class for Characidae incertae sedis (no rank).
/// NCBI TaxId: 533331
/// </summary>
public abstract class Characidae_incertae_sedis : Characidae, ICharacidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Characidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 533331;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Characidae_incertae_sedis";
}
