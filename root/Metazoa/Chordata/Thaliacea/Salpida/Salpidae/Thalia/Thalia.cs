using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thalia;

/// <summary>
/// Abstract class for Thalia (genus).
/// NCBI TaxId: 34760
/// </summary>
public abstract class Thalia : Salpidae, IThalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34760;

    /// <inheritdoc />
    public virtual string GenusName => "Thalia";

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
