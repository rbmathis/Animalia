using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Leptochilichthyidae.Leptochilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Leptochilichthyidae.Leptochilichthys.unclassified_Leptochilichthys;

/// <summary>
/// Abstract class for unclassified Leptochilichthys (no rank).
/// NCBI TaxId: 2726555
/// </summary>
public abstract class unclassified_Leptochilichthys : Leptochilichthys, Iunclassified_Leptochilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptochilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptochilichthys";
}
