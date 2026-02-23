namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Pangshura;

/// <summary>
/// Species: Pangshura smithii
/// NCBI TaxId: 254399
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangshura_smithii : Pangshura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangshura smithii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangshura_smithii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 254399;
}
