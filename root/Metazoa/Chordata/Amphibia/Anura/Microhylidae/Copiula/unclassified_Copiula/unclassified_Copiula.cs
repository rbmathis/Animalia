using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Copiula;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Copiula.unclassified_Copiula;

/// <summary>
/// Abstract class for unclassified Copiula (no rank).
/// NCBI TaxId: 2619982
/// </summary>
public abstract class unclassified_Copiula : Copiula, Iunclassified_Copiula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Copiula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619982;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Copiula";
}
