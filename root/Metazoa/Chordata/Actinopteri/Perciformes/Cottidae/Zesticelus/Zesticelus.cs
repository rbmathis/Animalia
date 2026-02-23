using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Zesticelus;

/// <summary>
/// Abstract class for Zesticelus (genus).
/// NCBI TaxId: 740937
/// </summary>
public abstract class Zesticelus : Cottidae, IZesticelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zesticelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740937;

    /// <inheritdoc />
    public virtual string GenusName => "Zesticelus";

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
