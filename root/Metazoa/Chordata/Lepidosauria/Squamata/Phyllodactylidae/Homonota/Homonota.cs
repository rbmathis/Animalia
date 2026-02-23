using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Homonota;

/// <summary>
/// Abstract class for Homonota (genus).
/// NCBI TaxId: 401548
/// </summary>
public abstract class Homonota : Phyllodactylidae, IHomonota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homonota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401548;

    /// <inheritdoc />
    public virtual string GenusName => "Homonota";

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
