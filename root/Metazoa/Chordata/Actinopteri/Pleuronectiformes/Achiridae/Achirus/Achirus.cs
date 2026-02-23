using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Achirus;

/// <summary>
/// Abstract class for Achirus (genus).
/// NCBI TaxId: 253937
/// </summary>
public abstract class Achirus : Achiridae, IAchirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 253937;

    /// <inheritdoc />
    public virtual string GenusName => "Achirus";

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
