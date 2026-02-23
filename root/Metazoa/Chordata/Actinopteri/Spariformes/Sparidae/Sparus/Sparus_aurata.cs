namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sparus;

/// <summary>
/// Species: Sparus aurata
/// NCBI TaxId: 8175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sparus_aurata : Sparus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sparus aurata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sparus_aurata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8175;
}
