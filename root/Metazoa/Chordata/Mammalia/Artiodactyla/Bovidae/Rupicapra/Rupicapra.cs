using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra;

/// <summary>
/// Abstract class for Rupicapra (genus).
/// NCBI TaxId: 34868
/// </summary>
public abstract class Rupicapra : Bovidae, IRupicapra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rupicapra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34868;

    /// <inheritdoc />
    public virtual string GenusName => "Rupicapra";

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
