namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus sp. 5 BOLD-2022
/// NCBI TaxId: 2980736
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_sp_5_BOLD_2022 : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus sp. 5 BOLD-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_sp_5_BOLD_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2980736;
}
