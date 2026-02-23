namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Rhynchopsitta;

/// <summary>
/// Species: Rhynchopsitta pachyrhyncha
/// NCBI TaxId: 309841
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchopsitta_pachyrhyncha : Rhynchopsitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchopsitta pachyrhyncha";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchopsitta_pachyrhyncha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 309841;
}
