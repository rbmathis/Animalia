namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus petersii
/// NCBI TaxId: 288555
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_petersii : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus petersii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_petersii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288555;
}
