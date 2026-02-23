using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea.Eurycea_troglodytes_complex;

/// <summary>
/// Abstract class for Eurycea troglodytes complex (no rank).
/// NCBI TaxId: 147905
/// </summary>
public abstract class Eurycea_troglodytes_complex : Eurycea, IEurycea_troglodytes_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurycea troglodytes complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eurycea_troglodytes_complex";
}
