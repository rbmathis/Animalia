using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Andigena;

/// <summary>
/// Abstract class for Andigena (genus).
/// NCBI TaxId: 91760
/// </summary>
public abstract class Andigena : Ramphastidae, IAndigena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andigena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91760;

    /// <inheritdoc />
    public virtual string GenusName => "Andigena";

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
