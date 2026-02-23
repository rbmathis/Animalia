namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra;

/// <summary>
/// Species: Rupicapra cf. pyrenaica VCB-2020
/// NCBI TaxId: 2716129
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rupicapra_cf_pyrenaica_VCB_2020 : Rupicapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rupicapra cf. pyrenaica VCB-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rupicapra_cf_pyrenaica_VCB_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2716129;
}
