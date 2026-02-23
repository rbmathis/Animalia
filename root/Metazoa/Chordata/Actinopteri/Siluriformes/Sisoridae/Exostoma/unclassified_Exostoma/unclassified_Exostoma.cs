using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Exostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Exostoma.unclassified_Exostoma;

/// <summary>
/// Abstract class for unclassified Exostoma (no rank).
/// NCBI TaxId: 2634435
/// </summary>
public abstract class unclassified_Exostoma : Exostoma, Iunclassified_Exostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Exostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634435;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Exostoma";
}
