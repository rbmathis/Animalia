using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Ritteriella;

/// <summary>
/// Abstract class for Ritteriella (genus).
/// NCBI TaxId: 641099
/// </summary>
public abstract class Ritteriella : Salpidae, IRitteriella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ritteriella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641099;

    /// <inheritdoc />
    public virtual string GenusName => "Ritteriella";

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
