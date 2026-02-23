namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Species: Agapornis swindernianus
/// NCBI TaxId: 1002726
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agapornis_swindernianus : Agapornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agapornis swindernianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agapornis_swindernianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002726;
}
