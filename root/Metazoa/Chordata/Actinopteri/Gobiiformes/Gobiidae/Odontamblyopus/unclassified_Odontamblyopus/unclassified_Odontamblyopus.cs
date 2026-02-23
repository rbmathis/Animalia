using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Odontamblyopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Odontamblyopus.unclassified_Odontamblyopus;

/// <summary>
/// Abstract class for unclassified Odontamblyopus (no rank).
/// NCBI TaxId: 2621471
/// </summary>
public abstract class unclassified_Odontamblyopus : Odontamblyopus, Iunclassified_Odontamblyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontamblyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621471;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontamblyopus";
}
