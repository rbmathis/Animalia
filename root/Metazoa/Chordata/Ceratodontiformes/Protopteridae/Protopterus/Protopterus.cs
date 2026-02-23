using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

/// <summary>
/// Abstract class for Protopterus (genus).
/// NCBI TaxId: 7885
/// </summary>
public abstract class Protopterus : Protopteridae, IProtopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7885;

    /// <inheritdoc />
    public virtual string GenusName => "Protopterus";

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
