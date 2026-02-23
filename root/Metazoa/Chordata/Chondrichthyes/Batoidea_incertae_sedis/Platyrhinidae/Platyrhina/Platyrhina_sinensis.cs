namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhina;

/// <summary>
/// Species: Platyrhina sinensis
/// NCBI TaxId: 195319
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platyrhina_sinensis : Platyrhina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platyrhina sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platyrhina_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 195319;
}
