namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra sibirica x Capra hircus
/// NCBI TaxId: 2544879
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_sibirica_x_Capra_hircus : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra sibirica x Capra hircus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_sibirica_x_Capra_hircus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2544879;
}
