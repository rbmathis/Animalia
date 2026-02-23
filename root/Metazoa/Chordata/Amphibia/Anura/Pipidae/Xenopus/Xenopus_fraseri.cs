namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus fraseri
/// NCBI TaxId: 191247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_fraseri : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus fraseri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_fraseri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191247;
}
