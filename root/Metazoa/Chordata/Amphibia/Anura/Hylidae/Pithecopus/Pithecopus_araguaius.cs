namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus;

/// <summary>
/// Species: Pithecopus araguaius
/// NCBI TaxId: 2034990
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecopus_araguaius : Pithecopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecopus araguaius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecopus_araguaius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2034990;
}
