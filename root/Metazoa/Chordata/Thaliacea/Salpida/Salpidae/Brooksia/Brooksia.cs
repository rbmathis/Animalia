using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Brooksia;

/// <summary>
/// Abstract class for Brooksia (genus).
/// NCBI TaxId: 942559
/// </summary>
public abstract class Brooksia : Salpidae, IBrooksia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brooksia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942559;

    /// <inheritdoc />
    public virtual string GenusName => "Brooksia";

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
