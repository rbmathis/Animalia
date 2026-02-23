namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus;

/// <summary>
/// Species: Bradypus sp. DEW-2006
/// NCBI TaxId: 380228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bradypus_sp_DEW_2006 : Bradypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bradypus sp. DEW-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bradypus_sp_DEW_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 380228;
}
