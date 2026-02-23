using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.salmonine_intergeneric_hybrids;

/// <summary>
/// Abstract class for salmonine intergeneric hybrids (no rank).
/// NCBI TaxId: 504571
/// </summary>
public abstract class salmonine_intergeneric_hybrids : Salmonidae, Isalmonine_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "salmonine intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 504571;

    /// <inheritdoc />
    public virtual string Description => "Taxon: salmonine_intergeneric_hybrids";
}
