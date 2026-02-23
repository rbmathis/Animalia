using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Aulopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Aulopus.unclassified_Aulopus;

/// <summary>
/// Abstract class for unclassified Aulopus (no rank).
/// NCBI TaxId: 2677041
/// </summary>
public abstract class unclassified_Aulopus : Aulopus, Iunclassified_Aulopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aulopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677041;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aulopus";
}
