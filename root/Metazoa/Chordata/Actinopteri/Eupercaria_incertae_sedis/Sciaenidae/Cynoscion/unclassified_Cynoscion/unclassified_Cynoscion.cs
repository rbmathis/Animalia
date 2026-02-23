using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Cynoscion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Cynoscion.unclassified_Cynoscion;

/// <summary>
/// Abstract class for unclassified Cynoscion (no rank).
/// NCBI TaxId: 2619041
/// </summary>
public abstract class unclassified_Cynoscion : Cynoscion, Iunclassified_Cynoscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynoscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619041;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynoscion";
}
