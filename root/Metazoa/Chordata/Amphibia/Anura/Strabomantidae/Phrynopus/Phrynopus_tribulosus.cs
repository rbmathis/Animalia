namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Phrynopus;

/// <summary>
/// Species: Phrynopus tribulosus
/// NCBI TaxId: 2006965
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynopus_tribulosus : Phrynopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynopus tribulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynopus_tribulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2006965;
}
