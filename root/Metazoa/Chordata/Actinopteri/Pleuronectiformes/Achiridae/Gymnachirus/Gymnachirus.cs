using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Gymnachirus;

/// <summary>
/// Abstract class for Gymnachirus (genus).
/// NCBI TaxId: 366935
/// </summary>
public abstract class Gymnachirus : Achiridae, IGymnachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366935;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnachirus";

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
