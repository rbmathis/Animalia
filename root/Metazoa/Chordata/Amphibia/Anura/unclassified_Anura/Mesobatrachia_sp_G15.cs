namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Mesobatrachia sp. G1.5
/// NCBI TaxId: 1702420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesobatrachia_sp_G15 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesobatrachia sp. G1.5";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesobatrachia_sp_G15";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1702420;
}
