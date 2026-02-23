namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pliotrema;

/// <summary>
/// Species: Pliotrema sp. 'shark1' MS-2020
/// NCBI TaxId: 2715529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pliotrema_sp_shark1_MS_2020 : Pliotrema
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pliotrema sp. 'shark1' MS-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pliotrema_sp_shark1_MS_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2715529;
}
