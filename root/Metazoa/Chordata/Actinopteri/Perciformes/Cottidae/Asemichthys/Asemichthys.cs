using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Asemichthys;

/// <summary>
/// Abstract class for Asemichthys (genus).
/// NCBI TaxId: 1638736
/// </summary>
public abstract class Asemichthys : Cottidae, IAsemichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asemichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1638736;

    /// <inheritdoc />
    public virtual string GenusName => "Asemichthys";

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
