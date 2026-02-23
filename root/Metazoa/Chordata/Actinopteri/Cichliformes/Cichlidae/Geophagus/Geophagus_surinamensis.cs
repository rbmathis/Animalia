namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Geophagus;

/// <summary>
/// Species: Geophagus surinamensis
/// NCBI TaxId: 284732
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geophagus_surinamensis : Geophagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geophagus surinamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geophagus_surinamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 284732;
}
