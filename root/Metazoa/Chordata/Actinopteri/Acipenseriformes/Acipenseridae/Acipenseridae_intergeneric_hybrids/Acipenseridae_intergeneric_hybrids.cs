using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenseridae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Acipenseridae intergeneric hybrids (no rank).
/// NCBI TaxId: 1358437
/// </summary>
public abstract class Acipenseridae_intergeneric_hybrids : Acipenseridae, IAcipenseridae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acipenseridae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1358437;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Acipenseridae_intergeneric_hybrids";
}
