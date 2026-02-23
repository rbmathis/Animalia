namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Delphinus;

/// <summary>
/// Species: Delphinus sp. 1 AN-2013
/// NCBI TaxId: 1303773
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Delphinus_sp_1_AN_2013 : Delphinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Delphinus sp. 1 AN-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Delphinus_sp_1_AN_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1303773;
}
