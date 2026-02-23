using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena.unclassified_Ptychadena;

/// <summary>
/// Abstract class for unclassified Ptychadena (no rank).
/// NCBI TaxId: 2618640
/// </summary>
public abstract class unclassified_Ptychadena : Ptychadena, Iunclassified_Ptychadena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ptychadena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618640;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ptychadena";
}
