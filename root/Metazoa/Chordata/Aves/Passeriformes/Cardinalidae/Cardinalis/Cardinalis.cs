using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Cardinalis;

/// <summary>
/// Abstract class for Cardinalis (genus).
/// NCBI TaxId: 56326
/// </summary>
public abstract class Cardinalis : Cardinalidae, ICardinalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardinalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56326;

    /// <inheritdoc />
    public virtual string GenusName => "Cardinalis";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
