namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes;

/// <summary>
/// Species: Herpestes vitticollis
/// NCBI TaxId: 643833
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Herpestes_vitticollis : Herpestes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Herpestes vitticollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Herpestes_vitticollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643833;
}
