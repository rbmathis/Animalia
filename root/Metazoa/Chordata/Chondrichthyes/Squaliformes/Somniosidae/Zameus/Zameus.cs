using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Zameus;

/// <summary>
/// Abstract class for Zameus (genus).
/// NCBI TaxId: 335009
/// </summary>
public abstract class Zameus : Somniosidae, IZameus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zameus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335009;

    /// <inheritdoc />
    public virtual string GenusName => "Zameus";

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
