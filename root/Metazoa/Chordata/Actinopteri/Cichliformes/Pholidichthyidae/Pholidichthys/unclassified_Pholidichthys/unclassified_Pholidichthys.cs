using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae.Pholidichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae.Pholidichthys.unclassified_Pholidichthys;

/// <summary>
/// Abstract class for unclassified Pholidichthys (no rank).
/// NCBI TaxId: 2962767
/// </summary>
public abstract class unclassified_Pholidichthys : Pholidichthys, Iunclassified_Pholidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pholidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2962767;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pholidichthys";
}
