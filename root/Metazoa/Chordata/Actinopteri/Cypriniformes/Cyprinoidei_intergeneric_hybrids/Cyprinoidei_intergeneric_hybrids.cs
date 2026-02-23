using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinoidei_intergeneric_hybrids;

/// <summary>
/// Abstract class for Cyprinoidei intergeneric hybrids (no rank).
/// NCBI TaxId: 564289
/// </summary>
public abstract class Cyprinoidei_intergeneric_hybrids : Cypriniformes, ICyprinoidei_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinoidei intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 564289;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cyprinoidei_intergeneric_hybrids";
}
