namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae.Solenodon;

/// <summary>
/// Species: Solenodon paradoxus
/// NCBI TaxId: 79805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Solenodon_paradoxus : Solenodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Solenodon paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Solenodon_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79805;
}
