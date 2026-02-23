using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Philantomba;

/// <summary>
/// Abstract class for Philantomba (genus).
/// NCBI TaxId: 907740
/// </summary>
public abstract class Philantomba : Bovidae, IPhilantomba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philantomba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 907740;

    /// <inheritdoc />
    public virtual string GenusName => "Philantomba";

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
