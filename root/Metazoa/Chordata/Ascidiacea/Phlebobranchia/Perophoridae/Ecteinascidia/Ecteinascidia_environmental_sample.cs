namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Ecteinascidia;

/// <summary>
/// Species: Ecteinascidia environmental sample
/// NCBI TaxId: 682794
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ecteinascidia_environmental_sample : Ecteinascidia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ecteinascidia environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ecteinascidia_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 682794;
}
