namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

/// <summary>
/// Species: Anoura sp. A CCA-2019
/// NCBI TaxId: 2563025
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anoura_sp_A_CCA_2019 : Anoura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anoura sp. A CCA-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anoura_sp_A_CCA_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2563025;
}
