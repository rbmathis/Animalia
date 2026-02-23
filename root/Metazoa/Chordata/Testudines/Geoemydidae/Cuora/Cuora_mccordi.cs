namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora mccordi
/// NCBI TaxId: 241437
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_mccordi : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora mccordi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_mccordi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241437;
}
