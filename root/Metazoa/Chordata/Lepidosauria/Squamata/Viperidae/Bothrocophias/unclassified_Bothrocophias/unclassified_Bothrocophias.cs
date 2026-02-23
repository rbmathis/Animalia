using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrocophias;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrocophias.unclassified_Bothrocophias;

/// <summary>
/// Abstract class for unclassified Bothrocophias (no rank).
/// NCBI TaxId: 3015508
/// </summary>
public abstract class unclassified_Bothrocophias : Bothrocophias, Iunclassified_Bothrocophias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bothrocophias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3015508;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bothrocophias";
}
