using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Hypsipetes;

/// <summary>
/// Abstract class for Hypsipetes (genus).
/// NCBI TaxId: 36295
/// </summary>
public abstract class Hypsipetes : Pycnonotidae, IHypsipetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsipetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36295;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsipetes";

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
