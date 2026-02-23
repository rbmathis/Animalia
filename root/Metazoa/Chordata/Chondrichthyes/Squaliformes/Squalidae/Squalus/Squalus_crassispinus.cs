namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus crassispinus
/// NCBI TaxId: 335031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_crassispinus : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus crassispinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_crassispinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 335031;
}
