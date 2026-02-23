namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhina;

/// <summary>
/// Species: Platyrhina hyugaensis
/// NCBI TaxId: 2012946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platyrhina_hyugaensis : Platyrhina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platyrhina hyugaensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platyrhina_hyugaensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2012946;
}
