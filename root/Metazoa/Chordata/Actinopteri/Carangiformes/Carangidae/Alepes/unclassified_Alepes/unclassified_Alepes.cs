using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Alepes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Alepes.unclassified_Alepes;

/// <summary>
/// Abstract class for unclassified Alepes (no rank).
/// NCBI TaxId: 2629042
/// </summary>
public abstract class unclassified_Alepes : Alepes, Iunclassified_Alepes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alepes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629042;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alepes";
}
