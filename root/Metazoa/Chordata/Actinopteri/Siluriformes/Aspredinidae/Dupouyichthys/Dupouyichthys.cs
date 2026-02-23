using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Dupouyichthys;

/// <summary>
/// Abstract class for Dupouyichthys (genus).
/// NCBI TaxId: 3110872
/// </summary>
public abstract class Dupouyichthys : Aspredinidae, IDupouyichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dupouyichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3110872;

    /// <inheritdoc />
    public virtual string GenusName => "Dupouyichthys";

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
