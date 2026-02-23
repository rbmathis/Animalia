namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Anhingidae.Anhinga;

/// <summary>
/// Species: Anhinga melanogaster
/// NCBI TaxId: 2039642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anhinga_melanogaster : Anhinga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anhinga melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anhinga_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2039642;
}
