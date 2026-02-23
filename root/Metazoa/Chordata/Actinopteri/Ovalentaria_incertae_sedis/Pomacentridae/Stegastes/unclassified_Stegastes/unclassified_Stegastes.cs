using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes.unclassified_Stegastes;

/// <summary>
/// Abstract class for unclassified Stegastes (no rank).
/// NCBI TaxId: 2626717
/// </summary>
public abstract class unclassified_Stegastes : Stegastes, Iunclassified_Stegastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stegastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626717;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stegastes";
}
