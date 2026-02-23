using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Anabas;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Anabas.unclassified_Anabas;

/// <summary>
/// Abstract class for unclassified Anabas (no rank).
/// NCBI TaxId: 2622153
/// </summary>
public abstract class unclassified_Anabas : Anabas, Iunclassified_Anabas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anabas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622153;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anabas";
}
