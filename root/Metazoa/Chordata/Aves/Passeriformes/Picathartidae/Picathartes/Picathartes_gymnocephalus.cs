namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae.Picathartes;

/// <summary>
/// Species: Picathartes gymnocephalus
/// NCBI TaxId: 175131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picathartes_gymnocephalus : Picathartes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picathartes gymnocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picathartes_gymnocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175131;
}
