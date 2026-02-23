using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius.Hynobius_incertae_sedis;

/// <summary>
/// Abstract class for Hynobius incertae sedis (no rank).
/// NCBI TaxId: 3035965
/// </summary>
public abstract class Hynobius_incertae_sedis : Hynobius, IHynobius_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hynobius incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3035965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Hynobius_incertae_sedis";
}
