using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Toxotidae.Toxotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Toxotidae.Toxotes.unclassified_Toxotes;

/// <summary>
/// Abstract class for unclassified Toxotes (no rank).
/// NCBI TaxId: 2639277
/// </summary>
public abstract class unclassified_Toxotes : Toxotes, Iunclassified_Toxotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Toxotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639277;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Toxotes";
}
