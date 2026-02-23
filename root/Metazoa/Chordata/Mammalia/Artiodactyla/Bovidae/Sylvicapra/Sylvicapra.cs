using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Sylvicapra;

/// <summary>
/// Abstract class for Sylvicapra (genus).
/// NCBI TaxId: 119561
/// </summary>
public abstract class Sylvicapra : Bovidae, ISylvicapra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvicapra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119561;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvicapra";

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
