using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela.unclassified_Mustela;

/// <summary>
/// Abstract class for unclassified Mustela (no rank).
/// NCBI TaxId: 2599795
/// </summary>
public abstract class unclassified_Mustela : Mustela, Iunclassified_Mustela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mustela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599795;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mustela";
}
