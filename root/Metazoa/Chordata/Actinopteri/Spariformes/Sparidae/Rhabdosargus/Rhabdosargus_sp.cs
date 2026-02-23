namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Rhabdosargus;

/// <summary>
/// Species: Rhabdosargus sp.
/// NCBI TaxId: 3081711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdosargus_sp : Rhabdosargus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdosargus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdosargus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3081711;
}
