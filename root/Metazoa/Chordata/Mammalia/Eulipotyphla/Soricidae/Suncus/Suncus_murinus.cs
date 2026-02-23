namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Species: Suncus murinus
/// NCBI TaxId: 9378
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suncus_murinus : Suncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suncus murinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suncus_murinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9378;
}
