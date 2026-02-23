namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Lybius;

/// <summary>
/// Species: Lybius melanopterus
/// NCBI TaxId: 240735
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lybius_melanopterus : Lybius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lybius melanopterus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lybius_melanopterus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 240735;
}
