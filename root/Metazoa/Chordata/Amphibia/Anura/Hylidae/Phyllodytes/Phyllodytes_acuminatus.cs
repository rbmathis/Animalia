namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllodytes;

/// <summary>
/// Species: Phyllodytes acuminatus
/// NCBI TaxId: 2728947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodytes_acuminatus : Phyllodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodytes acuminatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodytes_acuminatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2728947;
}
