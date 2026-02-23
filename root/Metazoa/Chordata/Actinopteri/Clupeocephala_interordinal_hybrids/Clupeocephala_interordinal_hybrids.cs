using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeocephala_interordinal_hybrids;

/// <summary>
/// Abstract class for Clupeocephala interordinal hybrids (no rank).
/// NCBI TaxId: 2949087
/// </summary>
public abstract class Clupeocephala_interordinal_hybrids : Actinopteri, IClupeocephala_interordinal_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeocephala interordinal hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2949087;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Clupeocephala_interordinal_hybrids";
}
