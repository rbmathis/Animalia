using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Odontophrynus;

/// <summary>
/// Abstract class for Odontophrynus (genus).
/// NCBI TaxId: 158479
/// </summary>
public abstract class Odontophrynus : Alsodidae, IOdontophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158479;

    /// <inheritdoc />
    public virtual string GenusName => "Odontophrynus";

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
