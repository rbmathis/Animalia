using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cairina;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cairina.unclassified_Cairina;

/// <summary>
/// Abstract class for unclassified Cairina (no rank).
/// NCBI TaxId: 2677066
/// </summary>
public abstract class unclassified_Cairina : Cairina, Iunclassified_Cairina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cairina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677066;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cairina";
}
