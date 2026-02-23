namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias sp. ZAM-2010
/// NCBI TaxId: 864835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_sp_ZAM_2010 : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias sp. ZAM-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_sp_ZAM_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 864835;
}
