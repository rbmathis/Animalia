namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

/// <summary>
/// Species: Ara ambiguus x Ara chloropterus
/// NCBI TaxId: 866918
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ara_ambiguus_x_Ara_chloropterus : Ara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ara ambiguus x Ara chloropterus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ara_ambiguus_x_Ara_chloropterus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 866918;
}
