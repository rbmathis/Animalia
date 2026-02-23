namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias sp. PL-2003
/// NCBI TaxId: 222700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_sp_PL_2003 : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias sp. PL-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_sp_PL_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 222700;
}
