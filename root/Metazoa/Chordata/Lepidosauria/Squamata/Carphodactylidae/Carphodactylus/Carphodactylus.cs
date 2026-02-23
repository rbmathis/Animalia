using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Carphodactylus;

/// <summary>
/// Abstract class for Carphodactylus (genus).
/// NCBI TaxId: 71020
/// </summary>
public abstract class Carphodactylus : Carphodactylidae, ICarphodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carphodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71020;

    /// <inheritdoc />
    public virtual string GenusName => "Carphodactylus";

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
