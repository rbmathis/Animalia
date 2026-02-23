using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyopterus.unclassified_Trachelyopterus;

/// <summary>
/// Abstract class for unclassified Trachelyopterus (no rank).
/// NCBI TaxId: 2613970
/// </summary>
public abstract class unclassified_Trachelyopterus : Trachelyopterus, Iunclassified_Trachelyopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachelyopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613970;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachelyopterus";
}
