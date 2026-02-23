using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Redunca;

/// <summary>
/// Abstract class for Redunca (genus).
/// NCBI TaxId: 59553
/// </summary>
public abstract class Redunca : Bovidae, IRedunca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Redunca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59553;

    /// <inheritdoc />
    public virtual string GenusName => "Redunca";

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
