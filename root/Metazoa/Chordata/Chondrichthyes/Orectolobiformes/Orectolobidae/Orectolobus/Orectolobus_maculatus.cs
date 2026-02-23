namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Orectolobus;

/// <summary>
/// Species: Orectolobus maculatus
/// NCBI TaxId: 168098
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orectolobus_maculatus : Orectolobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orectolobus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orectolobus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 168098;
}
