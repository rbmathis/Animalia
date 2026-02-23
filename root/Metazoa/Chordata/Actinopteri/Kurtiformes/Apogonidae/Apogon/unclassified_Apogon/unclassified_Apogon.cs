using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogon.unclassified_Apogon;

/// <summary>
/// Abstract class for unclassified Apogon (no rank).
/// NCBI TaxId: 638295
/// </summary>
public abstract class unclassified_Apogon : Apogon, Iunclassified_Apogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638295;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apogon";
}
