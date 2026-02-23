using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Chiropotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Chiropotes.unclassified_Chiropotes;

/// <summary>
/// Abstract class for unclassified Chiropotes (no rank).
/// NCBI TaxId: 2649368
/// </summary>
public abstract class unclassified_Chiropotes : Chiropotes, Iunclassified_Chiropotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiropotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiropotes";
}
