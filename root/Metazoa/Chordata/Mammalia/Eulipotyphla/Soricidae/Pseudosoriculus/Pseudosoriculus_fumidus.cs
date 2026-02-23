namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Pseudosoriculus;

/// <summary>
/// Species: Pseudosoriculus fumidus
/// NCBI TaxId: 3371150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudosoriculus_fumidus : Pseudosoriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudosoriculus fumidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudosoriculus_fumidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3371150;
}
