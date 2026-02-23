namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Pseudocheirus;

/// <summary>
/// Species: Pseudocheirus peregrinus
/// NCBI TaxId: 9333
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudocheirus_peregrinus : Pseudocheirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudocheirus peregrinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudocheirus_peregrinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9333;
}
