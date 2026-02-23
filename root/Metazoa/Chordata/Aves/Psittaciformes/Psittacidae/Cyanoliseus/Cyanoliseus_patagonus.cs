namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyanoliseus;

/// <summary>
/// Species: Cyanoliseus patagonus
/// NCBI TaxId: 309862
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanoliseus_patagonus : Cyanoliseus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanoliseus patagonus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanoliseus_patagonus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 309862;
}
