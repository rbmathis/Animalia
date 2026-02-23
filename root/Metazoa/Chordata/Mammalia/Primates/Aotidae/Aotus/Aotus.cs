using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Abstract class for Aotus (genus).
/// NCBI TaxId: 9504
/// </summary>
public abstract class Aotus : Aotidae, IAotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9504;

    /// <inheritdoc />
    public virtual string GenusName => "Aotus";

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
