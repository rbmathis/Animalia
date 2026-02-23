using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopygopsinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Schizopygopsinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2894333
/// </summary>
public abstract class Schizopygopsinae_intergeneric_hybrids : Cyprinidae, ISchizopygopsinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizopygopsinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2894333;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Schizopygopsinae_intergeneric_hybrids";
}
