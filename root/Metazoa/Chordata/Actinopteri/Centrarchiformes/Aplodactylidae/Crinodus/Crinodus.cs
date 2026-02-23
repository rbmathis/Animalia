using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae.Crinodus;

/// <summary>
/// Abstract class for Crinodus (genus).
/// NCBI TaxId: 143025
/// </summary>
public abstract class Crinodus : Aplodactylidae, ICrinodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crinodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143025;

    /// <inheritdoc />
    public virtual string GenusName => "Crinodus";

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
