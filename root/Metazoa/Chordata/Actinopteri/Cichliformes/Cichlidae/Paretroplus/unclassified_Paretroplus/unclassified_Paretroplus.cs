using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paretroplus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paretroplus.unclassified_Paretroplus;

/// <summary>
/// Abstract class for unclassified Paretroplus (no rank).
/// NCBI TaxId: 2620070
/// </summary>
public abstract class unclassified_Paretroplus : Paretroplus, Iunclassified_Paretroplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paretroplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620070;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paretroplus";
}
