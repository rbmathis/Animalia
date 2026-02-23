namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Cryptobatrachus;

/// <summary>
/// Species: Cryptobatrachus remotus
/// NCBI TaxId: 1730916
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptobatrachus_remotus : Cryptobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptobatrachus remotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptobatrachus_remotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1730916;
}
