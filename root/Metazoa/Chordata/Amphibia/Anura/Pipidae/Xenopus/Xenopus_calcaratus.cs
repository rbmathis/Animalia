namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus calcaratus
/// NCBI TaxId: 451444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_calcaratus : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus calcaratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_calcaratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 451444;
}
