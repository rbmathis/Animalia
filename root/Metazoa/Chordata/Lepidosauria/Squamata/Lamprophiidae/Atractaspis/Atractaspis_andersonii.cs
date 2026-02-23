namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Atractaspis;

/// <summary>
/// Species: Atractaspis andersonii
/// NCBI TaxId: 8600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atractaspis_andersonii : Atractaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atractaspis andersonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atractaspis_andersonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8600;
}
