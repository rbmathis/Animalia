using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

/// <summary>
/// Abstract class for Sphyrapicus (genus).
/// NCBI TaxId: 56078
/// </summary>
public abstract class Sphyrapicus : Picidae, ISphyrapicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphyrapicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56078;

    /// <inheritdoc />
    public virtual string GenusName => "Sphyrapicus";

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
