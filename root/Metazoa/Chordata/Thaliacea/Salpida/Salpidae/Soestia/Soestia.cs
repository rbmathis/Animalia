using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Soestia;

/// <summary>
/// Abstract class for Soestia (genus).
/// NCBI TaxId: 641095
/// </summary>
public abstract class Soestia : Salpidae, ISoestia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Soestia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641095;

    /// <inheritdoc />
    public virtual string GenusName => "Soestia";

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
