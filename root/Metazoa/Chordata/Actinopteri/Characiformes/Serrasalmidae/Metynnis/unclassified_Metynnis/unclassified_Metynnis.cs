using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Metynnis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Metynnis.unclassified_Metynnis;

/// <summary>
/// Abstract class for unclassified Metynnis (no rank).
/// NCBI TaxId: 2644296
/// </summary>
public abstract class unclassified_Metynnis : Metynnis, Iunclassified_Metynnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Metynnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644296;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Metynnis";
}
