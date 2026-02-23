namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Leptoglanis;

/// <summary>
/// Species: Leptoglanis xenognathus
/// NCBI TaxId: 1108842
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptoglanis_xenognathus : Leptoglanis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptoglanis xenognathus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptoglanis_xenognathus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1108842;
}
