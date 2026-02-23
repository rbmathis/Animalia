using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariidae_incertae_sedis;

/// <summary>
/// Abstract class for Loricariidae incertae sedis (no rank).
/// NCBI TaxId: 2927074
/// </summary>
public abstract class Loricariidae_incertae_sedis : Loricariidae, ILoricariidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loricariidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927074;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Loricariidae_incertae_sedis";
}
