using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Microtarsus;

/// <summary>
/// Abstract class for Microtarsus (genus).
/// NCBI TaxId: 3150824
/// </summary>
public abstract class Microtarsus : Pycnonotidae, IMicrotarsus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microtarsus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150824;

    /// <inheritdoc />
    public virtual string GenusName => "Microtarsus";

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
