using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Iole;

/// <summary>
/// Abstract class for Iole (genus).
/// NCBI TaxId: 374643
/// </summary>
public abstract class Iole : Pycnonotidae, IIole
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iole";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374643;

    /// <inheritdoc />
    public virtual string GenusName => "Iole";

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
