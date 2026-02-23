using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Anguis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Anguis.unclassified_Anguis;

/// <summary>
/// Abstract class for unclassified Anguis (no rank).
/// NCBI TaxId: 2629513
/// </summary>
public abstract class unclassified_Anguis : Anguis, Iunclassified_Anguis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anguis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629513;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anguis";
}
