using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Sorubim;

/// <summary>
/// Abstract class for Sorubim (genus).
/// NCBI TaxId: 238555
/// </summary>
public abstract class Sorubim : Pimelodidae, ISorubim
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sorubim";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238555;

    /// <inheritdoc />
    public virtual string GenusName => "Sorubim";

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
