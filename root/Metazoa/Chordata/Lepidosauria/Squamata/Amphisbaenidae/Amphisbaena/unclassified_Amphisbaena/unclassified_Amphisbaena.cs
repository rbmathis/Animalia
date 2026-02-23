using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena.unclassified_Amphisbaena;

/// <summary>
/// Abstract class for unclassified Amphisbaena (no rank).
/// NCBI TaxId: 2649908
/// </summary>
public abstract class unclassified_Amphisbaena : Amphisbaena, Iunclassified_Amphisbaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amphisbaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649908;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amphisbaena";
}
