namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Coelodonta;

/// <summary>
/// Species: Coelodonta antiquitatis
/// NCBI TaxId: 222863
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coelodonta_antiquitatis : Coelodonta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coelodonta antiquitatis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coelodonta_antiquitatis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 222863;
}
