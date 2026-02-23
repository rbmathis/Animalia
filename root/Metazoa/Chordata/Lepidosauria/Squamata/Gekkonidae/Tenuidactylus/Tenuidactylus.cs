using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Tenuidactylus;

/// <summary>
/// Abstract class for Tenuidactylus (genus).
/// NCBI TaxId: 1358810
/// </summary>
public abstract class Tenuidactylus : Gekkonidae, ITenuidactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tenuidactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1358810;

    /// <inheritdoc />
    public virtual string GenusName => "Tenuidactylus";

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
