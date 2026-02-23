namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Daubentoniidae.Daubentonia;

/// <summary>
/// Species: Daubentonia madagascariensis
/// NCBI TaxId: 31869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Daubentonia_madagascariensis : Daubentonia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Daubentonia madagascariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Daubentonia_madagascariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 31869;
}
