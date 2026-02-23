namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora galbinifrons
/// NCBI TaxId: 204968
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_galbinifrons : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora galbinifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_galbinifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 204968;
}
