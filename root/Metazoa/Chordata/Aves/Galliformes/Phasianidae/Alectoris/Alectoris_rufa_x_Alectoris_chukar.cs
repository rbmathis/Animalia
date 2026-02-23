namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Alectoris;

/// <summary>
/// Species: Alectoris rufa x Alectoris chukar
/// NCBI TaxId: 249542
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alectoris_rufa_x_Alectoris_chukar : Alectoris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alectoris rufa x Alectoris chukar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alectoris_rufa_x_Alectoris_chukar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 249542;
}
