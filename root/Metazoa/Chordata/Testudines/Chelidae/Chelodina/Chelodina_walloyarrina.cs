namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina walloyarrina
/// NCBI TaxId: 3146101
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_walloyarrina : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina walloyarrina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_walloyarrina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3146101;
}
