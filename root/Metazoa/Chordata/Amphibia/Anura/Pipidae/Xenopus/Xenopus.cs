using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Abstract class for Xenopus (genus).
/// NCBI TaxId: 8353
/// </summary>
public abstract class Xenopus : Pipidae, IXenopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8353;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopus";

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
