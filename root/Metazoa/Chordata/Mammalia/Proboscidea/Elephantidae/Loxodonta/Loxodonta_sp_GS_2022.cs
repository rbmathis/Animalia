namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Species: Loxodonta sp. GS-2022
/// NCBI TaxId: 2928102
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loxodonta_sp_GS_2022 : Loxodonta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loxodonta sp. GS-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loxodonta_sp_GS_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2928102;
}
