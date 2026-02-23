using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Pteronotus;

/// <summary>
/// Abstract class for Pteronotus (genus).
/// NCBI TaxId: 59475
/// </summary>
public abstract class Pteronotus : Mormoopidae, IPteronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59475;

    /// <inheritdoc />
    public virtual string GenusName => "Pteronotus";

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
