using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Metcalfina;

/// <summary>
/// Abstract class for Metcalfina (genus).
/// NCBI TaxId: 641097
/// </summary>
public abstract class Metcalfina : Salpidae, IMetcalfina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metcalfina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641097;

    /// <inheritdoc />
    public virtual string GenusName => "Metcalfina";

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
