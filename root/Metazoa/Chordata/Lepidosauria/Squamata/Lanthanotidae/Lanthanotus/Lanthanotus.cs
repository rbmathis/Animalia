using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lanthanotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lanthanotidae.Lanthanotus;

/// <summary>
/// Abstract class for Lanthanotus (genus).
/// NCBI TaxId: 62057
/// </summary>
public abstract class Lanthanotus : Lanthanotidae, ILanthanotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lanthanotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62057;

    /// <inheritdoc />
    public virtual string GenusName => "Lanthanotus";

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
