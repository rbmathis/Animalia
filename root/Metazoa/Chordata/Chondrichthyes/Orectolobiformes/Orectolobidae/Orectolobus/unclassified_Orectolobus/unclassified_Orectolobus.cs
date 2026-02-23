using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Orectolobus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Orectolobus.unclassified_Orectolobus;

/// <summary>
/// Abstract class for unclassified Orectolobus (no rank).
/// NCBI TaxId: 2636165
/// </summary>
public abstract class unclassified_Orectolobus : Orectolobus, Iunclassified_Orectolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orectolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636165;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orectolobus";
}
