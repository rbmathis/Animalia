namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Callorhinus;

/// <summary>
/// Species: Callorhinus ursinus
/// NCBI TaxId: 34884
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callorhinus_ursinus : Callorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callorhinus ursinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callorhinus_ursinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34884;
}
