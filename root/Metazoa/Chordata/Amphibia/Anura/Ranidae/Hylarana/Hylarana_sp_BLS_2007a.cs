namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Species: Hylarana sp. BLS-2007a
/// NCBI TaxId: 431031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylarana_sp_BLS_2007a : Hylarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylarana sp. BLS-2007a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylarana_sp_BLS_2007a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 431031;
}
