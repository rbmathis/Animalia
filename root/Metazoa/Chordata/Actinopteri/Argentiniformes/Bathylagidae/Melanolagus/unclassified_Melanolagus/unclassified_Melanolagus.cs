using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Melanolagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Melanolagus.unclassified_Melanolagus;

/// <summary>
/// Abstract class for unclassified Melanolagus (no rank).
/// NCBI TaxId: 2626305
/// </summary>
public abstract class unclassified_Melanolagus : Melanolagus, Iunclassified_Melanolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanolagus";
}
