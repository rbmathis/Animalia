using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Flectonotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Flectonotus.unclassified_Flectonotus;

/// <summary>
/// Abstract class for unclassified Flectonotus (no rank).
/// NCBI TaxId: 2642544
/// </summary>
public abstract class unclassified_Flectonotus : Flectonotus, Iunclassified_Flectonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Flectonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642544;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Flectonotus";
}
