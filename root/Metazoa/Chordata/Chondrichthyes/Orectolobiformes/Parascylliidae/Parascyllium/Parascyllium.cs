using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Parascylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Parascylliidae.Parascyllium;

/// <summary>
/// Abstract class for Parascyllium (genus).
/// NCBI TaxId: 1213741
/// </summary>
public abstract class Parascyllium : Parascylliidae, IParascyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1213741;

    /// <inheritdoc />
    public virtual string GenusName => "Parascyllium";

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
