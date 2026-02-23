using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mangarinus;

/// <summary>
/// Abstract class for Mangarinus (genus).
/// NCBI TaxId: 2507736
/// </summary>
public abstract class Mangarinus : Gobiidae, IMangarinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mangarinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2507736;

    /// <inheritdoc />
    public virtual string GenusName => "Mangarinus";

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
