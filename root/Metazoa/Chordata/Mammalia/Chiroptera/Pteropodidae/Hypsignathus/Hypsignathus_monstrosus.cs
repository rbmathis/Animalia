namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Hypsignathus;

/// <summary>
/// Species: Hypsignathus monstrosus
/// NCBI TaxId: 448084
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypsignathus_monstrosus : Hypsignathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypsignathus monstrosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypsignathus_monstrosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 448084;
}
