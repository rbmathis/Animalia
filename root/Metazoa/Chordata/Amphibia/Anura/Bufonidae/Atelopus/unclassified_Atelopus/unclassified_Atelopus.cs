using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus.unclassified_Atelopus;

/// <summary>
/// Abstract class for unclassified Atelopus (no rank).
/// NCBI TaxId: 2621912
/// </summary>
public abstract class unclassified_Atelopus : Atelopus, Iunclassified_Atelopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atelopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621912;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atelopus";
}
