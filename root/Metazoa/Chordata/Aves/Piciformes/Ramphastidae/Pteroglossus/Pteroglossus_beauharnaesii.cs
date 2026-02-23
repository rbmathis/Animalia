namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Pteroglossus;

/// <summary>
/// Species: Pteroglossus beauharnaesii
/// NCBI TaxId: 95722
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteroglossus_beauharnaesii : Pteroglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteroglossus beauharnaesii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteroglossus_beauharnaesii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95722;
}
