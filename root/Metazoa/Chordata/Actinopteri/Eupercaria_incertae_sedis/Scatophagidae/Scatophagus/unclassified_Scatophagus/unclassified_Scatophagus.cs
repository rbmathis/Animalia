using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Scatophagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Scatophagus.unclassified_Scatophagus;

/// <summary>
/// Abstract class for unclassified Scatophagus (no rank).
/// NCBI TaxId: 2677881
/// </summary>
public abstract class unclassified_Scatophagus : Scatophagus, Iunclassified_Scatophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scatophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scatophagus";
}
