using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Torquigener;

/// <summary>
/// Abstract class for Torquigener (genus).
/// NCBI TaxId: 303747
/// </summary>
public abstract class Torquigener : Tetraodontidae, ITorquigener
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Torquigener";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303747;

    /// <inheritdoc />
    public virtual string GenusName => "Torquigener";

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
