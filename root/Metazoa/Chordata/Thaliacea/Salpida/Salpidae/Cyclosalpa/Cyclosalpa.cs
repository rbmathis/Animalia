using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Cyclosalpa;

/// <summary>
/// Abstract class for Cyclosalpa (genus).
/// NCBI TaxId: 569442
/// </summary>
public abstract class Cyclosalpa : Salpidae, ICyclosalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclosalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 569442;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclosalpa";

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
