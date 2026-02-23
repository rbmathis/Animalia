using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Halimochirurgus;

/// <summary>
/// Abstract class for Halimochirurgus (genus).
/// NCBI TaxId: 1367224
/// </summary>
public abstract class Halimochirurgus : Triacanthodidae, IHalimochirurgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halimochirurgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1367224;

    /// <inheritdoc />
    public virtual string GenusName => "Halimochirurgus";

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
