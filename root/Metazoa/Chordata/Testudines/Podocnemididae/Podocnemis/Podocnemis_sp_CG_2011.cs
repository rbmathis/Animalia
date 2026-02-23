namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Species: Podocnemis sp. CG-2011
/// NCBI TaxId: 1053019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podocnemis_sp_CG_2011 : Podocnemis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podocnemis sp. CG-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podocnemis_sp_CG_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1053019;
}
