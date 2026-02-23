using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pristiapogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pristiapogon.unclassified_Pristiapogon;

/// <summary>
/// Abstract class for unclassified Pristiapogon (no rank).
/// NCBI TaxId: 2989929
/// </summary>
public abstract class unclassified_Pristiapogon : Pristiapogon, Iunclassified_Pristiapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristiapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristiapogon";
}
