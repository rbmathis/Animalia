using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Chrysichthys;

/// <summary>
/// Abstract class for Chrysichthys (genus).
/// NCBI TaxId: 236587
/// </summary>
public abstract class Chrysichthys : Claroteidae, IChrysichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 236587;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysichthys";

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
