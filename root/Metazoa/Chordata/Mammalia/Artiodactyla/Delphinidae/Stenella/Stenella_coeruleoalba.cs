namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella;

/// <summary>
/// Species: Stenella coeruleoalba
/// NCBI TaxId: 9737
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stenella_coeruleoalba : Stenella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stenella coeruleoalba";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stenella_coeruleoalba";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9737;
}
