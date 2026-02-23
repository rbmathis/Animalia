namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Species: Hylarana sp. C MS-2010
/// NCBI TaxId: 714904
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylarana_sp_C_MS_2010 : Hylarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylarana sp. C MS-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylarana_sp_C_MS_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 714904;
}
