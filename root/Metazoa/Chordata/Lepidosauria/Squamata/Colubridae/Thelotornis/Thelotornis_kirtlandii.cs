namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thelotornis;

/// <summary>
/// Species: Thelotornis kirtlandii
/// NCBI TaxId: 292880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thelotornis_kirtlandii : Thelotornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thelotornis kirtlandii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thelotornis_kirtlandii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 292880;
}
