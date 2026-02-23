using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Sorubimichthys;

/// <summary>
/// Abstract class for Sorubimichthys (genus).
/// NCBI TaxId: 337657
/// </summary>
public abstract class Sorubimichthys : Pimelodidae, ISorubimichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sorubimichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337657;

    /// <inheritdoc />
    public virtual string GenusName => "Sorubimichthys";

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
