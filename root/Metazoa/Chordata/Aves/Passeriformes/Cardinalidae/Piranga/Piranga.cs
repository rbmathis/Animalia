using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Piranga;

/// <summary>
/// Abstract class for Piranga (genus).
/// NCBI TaxId: 36732
/// </summary>
public abstract class Piranga : Cardinalidae, IPiranga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piranga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36732;

    /// <inheritdoc />
    public virtual string GenusName => "Piranga";

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
