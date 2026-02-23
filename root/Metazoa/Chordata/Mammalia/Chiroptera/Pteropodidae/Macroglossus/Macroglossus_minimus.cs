namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Macroglossus;

/// <summary>
/// Species: Macroglossus minimus
/// NCBI TaxId: 29076
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macroglossus_minimus : Macroglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macroglossus minimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macroglossus_minimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29076;
}
