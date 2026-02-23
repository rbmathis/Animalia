using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Lepidonectes;

/// <summary>
/// Abstract class for Lepidonectes (genus).
/// NCBI TaxId: 879849
/// </summary>
public abstract class Lepidonectes : Tripterygiidae, ILepidonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879849;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidonectes";

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
