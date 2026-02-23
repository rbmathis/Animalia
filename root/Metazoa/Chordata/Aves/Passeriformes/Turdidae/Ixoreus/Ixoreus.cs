using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Ixoreus;

/// <summary>
/// Abstract class for Ixoreus (genus).
/// NCBI TaxId: 172415
/// </summary>
public abstract class Ixoreus : Turdidae, IIxoreus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixoreus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172415;

    /// <inheritdoc />
    public virtual string GenusName => "Ixoreus";

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
