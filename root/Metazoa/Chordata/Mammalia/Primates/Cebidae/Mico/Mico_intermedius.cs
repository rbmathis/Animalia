namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

/// <summary>
/// Species: Mico intermedius
/// NCBI TaxId: 2592805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mico_intermedius : Mico
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mico intermedius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mico_intermedius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2592805;
}
