using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Helicosalpa;

/// <summary>
/// Abstract class for Helicosalpa (genus).
/// NCBI TaxId: 3042084
/// </summary>
public abstract class Helicosalpa : Salpidae, IHelicosalpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helicosalpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3042084;

    /// <inheritdoc />
    public virtual string GenusName => "Helicosalpa";

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
