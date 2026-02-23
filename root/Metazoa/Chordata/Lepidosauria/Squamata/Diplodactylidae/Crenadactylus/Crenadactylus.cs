using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Crenadactylus;

/// <summary>
/// Abstract class for Crenadactylus (genus).
/// NCBI TaxId: 255195
/// </summary>
public abstract class Crenadactylus : Diplodactylidae, ICrenadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crenadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255195;

    /// <inheritdoc />
    public virtual string GenusName => "Crenadactylus";

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
