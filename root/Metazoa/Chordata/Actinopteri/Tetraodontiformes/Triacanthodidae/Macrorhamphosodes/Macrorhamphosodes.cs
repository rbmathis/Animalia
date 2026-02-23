using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Macrorhamphosodes;

/// <summary>
/// Abstract class for Macrorhamphosodes (genus).
/// NCBI TaxId: 384592
/// </summary>
public abstract class Macrorhamphosodes : Triacanthodidae, IMacrorhamphosodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrorhamphosodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 384592;

    /// <inheritdoc />
    public virtual string GenusName => "Macrorhamphosodes";

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
