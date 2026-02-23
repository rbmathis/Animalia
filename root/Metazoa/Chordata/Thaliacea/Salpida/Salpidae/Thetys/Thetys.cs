using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thetys;

/// <summary>
/// Abstract class for Thetys (genus).
/// NCBI TaxId: 942564
/// </summary>
public abstract class Thetys : Salpidae, IThetys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thetys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942564;

    /// <inheritdoc />
    public virtual string GenusName => "Thetys";

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
