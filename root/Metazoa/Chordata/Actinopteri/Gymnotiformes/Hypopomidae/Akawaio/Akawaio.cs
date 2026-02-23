using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Akawaio;

/// <summary>
/// Abstract class for Akawaio (genus).
/// NCBI TaxId: 1425326
/// </summary>
public abstract class Akawaio : Hypopomidae, IAkawaio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akawaio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1425326;

    /// <inheritdoc />
    public virtual string GenusName => "Akawaio";

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
