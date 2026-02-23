using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceiidae_incertae_sedis;

/// <summary>
/// Abstract class for Synanceiidae incertae sedis (no rank).
/// NCBI TaxId: 2927069
/// </summary>
public abstract class Synanceiidae_incertae_sedis : Synanceiidae, ISynanceiidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synanceiidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927069;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Synanceiidae_incertae_sedis";
}
