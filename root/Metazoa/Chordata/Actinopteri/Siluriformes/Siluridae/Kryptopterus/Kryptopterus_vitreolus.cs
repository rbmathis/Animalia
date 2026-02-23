namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Kryptopterus;

/// <summary>
/// Species: Kryptopterus vitreolus
/// NCBI TaxId: 2012678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kryptopterus_vitreolus : Kryptopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kryptopterus vitreolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kryptopterus_vitreolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2012678;
}
