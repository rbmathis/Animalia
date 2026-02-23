using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Dysalotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Dysalotus.unclassified_Dysalotus;

/// <summary>
/// Abstract class for unclassified Dysalotus (no rank).
/// NCBI TaxId: 2629226
/// </summary>
public abstract class unclassified_Dysalotus : Dysalotus, Iunclassified_Dysalotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dysalotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629226;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dysalotus";
}
