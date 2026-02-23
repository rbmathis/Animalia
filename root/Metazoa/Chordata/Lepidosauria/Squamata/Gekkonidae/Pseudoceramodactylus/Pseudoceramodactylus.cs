using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pseudoceramodactylus;

/// <summary>
/// Abstract class for Pseudoceramodactylus (genus).
/// NCBI TaxId: 1355907
/// </summary>
public abstract class Pseudoceramodactylus : Gekkonidae, IPseudoceramodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoceramodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1355907;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoceramodactylus";

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
