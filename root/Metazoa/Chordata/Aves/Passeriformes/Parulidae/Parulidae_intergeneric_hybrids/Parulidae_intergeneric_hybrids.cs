using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Parulidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Parulidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527871
/// </summary>
public abstract class Parulidae_intergeneric_hybrids : Parulidae, IParulidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parulidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527871;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Parulidae_intergeneric_hybrids";
}
