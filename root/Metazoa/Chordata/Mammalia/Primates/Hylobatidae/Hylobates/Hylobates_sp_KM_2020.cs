namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates sp. KM-2020
/// NCBI TaxId: 2768846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_sp_KM_2020 : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates sp. KM-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_sp_KM_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2768846;
}
