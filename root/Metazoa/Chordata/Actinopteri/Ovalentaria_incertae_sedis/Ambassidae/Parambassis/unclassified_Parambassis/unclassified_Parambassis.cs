using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Parambassis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Parambassis.unclassified_Parambassis;

/// <summary>
/// Abstract class for unclassified Parambassis (no rank).
/// NCBI TaxId: 2645169
/// </summary>
public abstract class unclassified_Parambassis : Parambassis, Iunclassified_Parambassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parambassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645169;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parambassis";
}
