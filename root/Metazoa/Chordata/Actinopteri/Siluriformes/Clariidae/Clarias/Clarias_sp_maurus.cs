namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias sp. 'maurus'
/// NCBI TaxId: 222699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_sp_maurus : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias sp. 'maurus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_sp_maurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 222699;
}
