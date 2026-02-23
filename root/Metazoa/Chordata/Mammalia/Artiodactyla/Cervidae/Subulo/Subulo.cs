using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Subulo;

/// <summary>
/// Abstract class for Subulo (genus).
/// NCBI TaxId: 3042400
/// </summary>
public abstract class Subulo : Cervidae, ISubulo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Subulo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3042400;

    /// <inheritdoc />
    public virtual string GenusName => "Subulo";

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
