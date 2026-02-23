namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Trichechidae.Trichechus;

/// <summary>
/// Species: Trichechus manatus
/// NCBI TaxId: 9778
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trichechus_manatus : Trichechus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trichechus manatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trichechus_manatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9778;
}
