using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis.unclassified_Oreochromis;

/// <summary>
/// Abstract class for unclassified Oreochromis (no rank).
/// NCBI TaxId: 2620916
/// </summary>
public abstract class unclassified_Oreochromis : Oreochromis, Iunclassified_Oreochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620916;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreochromis";
}
