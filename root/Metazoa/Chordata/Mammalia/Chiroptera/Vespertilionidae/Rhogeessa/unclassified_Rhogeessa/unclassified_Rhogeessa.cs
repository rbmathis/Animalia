using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhogeessa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhogeessa.unclassified_Rhogeessa;

/// <summary>
/// Abstract class for unclassified Rhogeessa (no rank).
/// NCBI TaxId: 2622910
/// </summary>
public abstract class unclassified_Rhogeessa : Rhogeessa, Iunclassified_Rhogeessa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhogeessa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622910;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhogeessa";
}
