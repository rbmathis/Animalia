namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dives;

/// <summary>
/// Species: Dives sp. 'bonariensis'
/// NCBI TaxId: 138957
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dives_sp_bonariensis : Dives
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dives sp. 'bonariensis'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dives_sp_bonariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 138957;
}
