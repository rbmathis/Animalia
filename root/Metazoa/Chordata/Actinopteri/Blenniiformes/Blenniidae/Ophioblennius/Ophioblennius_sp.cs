namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ophioblennius;

/// <summary>
/// Species: Ophioblennius sp.
/// NCBI TaxId: 3608351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophioblennius_sp : Ophioblennius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophioblennius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophioblennius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3608351;
}
