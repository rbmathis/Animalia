using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Ixonotus;

/// <summary>
/// Abstract class for Ixonotus (genus).
/// NCBI TaxId: 182901
/// </summary>
public abstract class Ixonotus : Pycnonotidae, IIxonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182901;

    /// <inheritdoc />
    public virtual string GenusName => "Ixonotus";

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
