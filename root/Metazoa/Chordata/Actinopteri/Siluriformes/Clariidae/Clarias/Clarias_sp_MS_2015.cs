namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias sp. MS-2015
/// NCBI TaxId: 1739089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_sp_MS_2015 : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias sp. MS-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_sp_MS_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1739089;
}
