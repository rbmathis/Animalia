using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnini_intergeneric_hybrids;

/// <summary>
/// Abstract class for Thunnini intergeneric hybrids (no rank).
/// NCBI TaxId: 2720108
/// </summary>
public abstract class Thunnini_intergeneric_hybrids : Scombridae, IThunnini_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thunnini intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2720108;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Thunnini_intergeneric_hybrids";
}
