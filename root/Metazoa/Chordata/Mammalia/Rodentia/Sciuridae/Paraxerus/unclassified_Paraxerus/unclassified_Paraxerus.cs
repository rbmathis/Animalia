using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Paraxerus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Paraxerus.unclassified_Paraxerus;

/// <summary>
/// Abstract class for unclassified Paraxerus (no rank).
/// NCBI TaxId: 3465176
/// </summary>
public abstract class unclassified_Paraxerus : Paraxerus, Iunclassified_Paraxerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraxerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3465176;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraxerus";
}
