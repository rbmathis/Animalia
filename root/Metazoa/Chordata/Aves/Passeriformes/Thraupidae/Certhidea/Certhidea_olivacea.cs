namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Certhidea;

/// <summary>
/// Species: Certhidea olivacea
/// NCBI TaxId: 48880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Certhidea_olivacea : Certhidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Certhidea olivacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Certhidea_olivacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48880;
}
