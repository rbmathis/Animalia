namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Anura sp. BOLD:AAU2363
/// NCBI TaxId: 1067606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anura_sp_BOLDAAU2363 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anura sp. BOLD:AAU2363";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anura_sp_BOLDAAU2363";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1067606;
}
