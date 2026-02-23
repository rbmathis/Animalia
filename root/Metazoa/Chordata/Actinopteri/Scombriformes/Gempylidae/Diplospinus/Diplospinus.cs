using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Diplospinus;

/// <summary>
/// Abstract class for Diplospinus (genus).
/// NCBI TaxId: 372795
/// </summary>
public abstract class Diplospinus : Gempylidae, IDiplospinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplospinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372795;

    /// <inheritdoc />
    public virtual string GenusName => "Diplospinus";

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
