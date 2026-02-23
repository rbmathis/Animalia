using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Herklotsichthys;

/// <summary>
/// Abstract class for Herklotsichthys (genus).
/// NCBI TaxId: 997023
/// </summary>
public abstract class Herklotsichthys : Clupeidae, IHerklotsichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herklotsichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 997023;

    /// <inheritdoc />
    public virtual string GenusName => "Herklotsichthys";

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
