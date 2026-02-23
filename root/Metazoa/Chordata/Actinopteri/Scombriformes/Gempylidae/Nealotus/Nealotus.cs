using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Nealotus;

/// <summary>
/// Abstract class for Nealotus (genus).
/// NCBI TaxId: 372799
/// </summary>
public abstract class Nealotus : Gempylidae, INealotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nealotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372799;

    /// <inheritdoc />
    public virtual string GenusName => "Nealotus";

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
