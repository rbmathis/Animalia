namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius polyuranodon
/// NCBI TaxId: 796022
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_polyuranodon : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius polyuranodon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_polyuranodon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 796022;
}
