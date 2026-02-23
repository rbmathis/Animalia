using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Pudu;

/// <summary>
/// Abstract class for Pudu (genus).
/// NCBI TaxId: 163860
/// </summary>
public abstract class Pudu : Cervidae, IPudu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pudu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163860;

    /// <inheritdoc />
    public virtual string GenusName => "Pudu";

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
