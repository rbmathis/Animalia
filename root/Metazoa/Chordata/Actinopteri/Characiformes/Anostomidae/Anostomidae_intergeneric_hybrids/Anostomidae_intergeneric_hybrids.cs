using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Anostomidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Anostomidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3682377
/// </summary>
public abstract class Anostomidae_intergeneric_hybrids : Anostomidae, IAnostomidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anostomidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3682377;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Anostomidae_intergeneric_hybrids";
}
