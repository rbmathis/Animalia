namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nannophryne;

/// <summary>
/// Species: Nannophryne variegata
/// NCBI TaxId: 248945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannophryne_variegata : Nannophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannophryne variegata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannophryne_variegata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248945;
}
