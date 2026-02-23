using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Trixiphichthys;

/// <summary>
/// Abstract class for Trixiphichthys (genus).
/// NCBI TaxId: 245702
/// </summary>
public abstract class Trixiphichthys : Triacanthidae, ITrixiphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trixiphichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245702;

    /// <inheritdoc />
    public virtual string GenusName => "Trixiphichthys";

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
