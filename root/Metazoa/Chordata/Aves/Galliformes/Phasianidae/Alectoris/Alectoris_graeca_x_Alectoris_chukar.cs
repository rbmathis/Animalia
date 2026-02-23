namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Alectoris;

/// <summary>
/// Species: Alectoris graeca x Alectoris chukar
/// NCBI TaxId: 1864497
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alectoris_graeca_x_Alectoris_chukar : Alectoris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alectoris graeca x Alectoris chukar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alectoris_graeca_x_Alectoris_chukar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1864497;
}
