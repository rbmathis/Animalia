using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paraneetroplus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paraneetroplus.unclassified_Paraneetroplus;

/// <summary>
/// Abstract class for unclassified Paraneetroplus (no rank).
/// NCBI TaxId: 2634180
/// </summary>
public abstract class unclassified_Paraneetroplus : Paraneetroplus, Iunclassified_Paraneetroplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraneetroplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634180;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraneetroplus";
}
