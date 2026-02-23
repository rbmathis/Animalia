namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Petromyscus;

/// <summary>
/// Species: Petromyscus monticularis
/// NCBI TaxId: 243068
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petromyscus_monticularis : Petromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petromyscus monticularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petromyscus_monticularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 243068;
}
