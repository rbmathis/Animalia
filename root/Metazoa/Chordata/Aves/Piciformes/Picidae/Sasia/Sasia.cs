using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sasia;

/// <summary>
/// Abstract class for Sasia (genus).
/// NCBI TaxId: 315370
/// </summary>
public abstract class Sasia : Picidae, ISasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315370;

    /// <inheritdoc />
    public virtual string GenusName => "Sasia";

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
