using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Grampus;

/// <summary>
/// Abstract class for Grampus (genus).
/// NCBI TaxId: 83652
/// </summary>
public abstract class Grampus : Delphinidae, IGrampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83652;

    /// <inheritdoc />
    public virtual string GenusName => "Grampus";

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
