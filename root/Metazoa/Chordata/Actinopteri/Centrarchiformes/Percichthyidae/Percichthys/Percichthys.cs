using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Percichthys;

/// <summary>
/// Abstract class for Percichthys (genus).
/// NCBI TaxId: 270565
/// </summary>
public abstract class Percichthys : Percichthyidae, IPercichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270565;

    /// <inheritdoc />
    public virtual string GenusName => "Percichthys";

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
