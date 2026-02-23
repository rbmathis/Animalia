using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Nactus;

/// <summary>
/// Abstract class for Nactus (genus).
/// NCBI TaxId: 221564
/// </summary>
public abstract class Nactus : Gekkonidae, INactus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nactus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221564;

    /// <inheritdoc />
    public virtual string GenusName => "Nactus";

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
