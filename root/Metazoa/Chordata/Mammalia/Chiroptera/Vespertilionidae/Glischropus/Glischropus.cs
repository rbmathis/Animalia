using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Glischropus;

/// <summary>
/// Abstract class for Glischropus (genus).
/// NCBI TaxId: 526817
/// </summary>
public abstract class Glischropus : Vespertilionidae, IGlischropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glischropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526817;

    /// <inheritdoc />
    public virtual string GenusName => "Glischropus";

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
