using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amphiprion.unclassified_Amphiprion;

/// <summary>
/// Abstract class for unclassified Amphiprion (no rank).
/// NCBI TaxId: 2629955
/// </summary>
public abstract class unclassified_Amphiprion : Amphiprion, Iunclassified_Amphiprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amphiprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amphiprion";
}
