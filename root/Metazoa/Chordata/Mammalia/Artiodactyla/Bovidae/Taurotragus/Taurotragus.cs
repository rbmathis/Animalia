using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Taurotragus;

/// <summary>
/// Abstract class for Taurotragus (genus).
/// NCBI TaxId: 303929
/// </summary>
public abstract class Taurotragus : Bovidae, ITaurotragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taurotragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303929;

    /// <inheritdoc />
    public virtual string GenusName => "Taurotragus";

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
