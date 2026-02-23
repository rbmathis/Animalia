using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Mimetillus;

/// <summary>
/// Abstract class for Mimetillus (genus).
/// NCBI TaxId: 2093333
/// </summary>
public abstract class Mimetillus : Vespertilionidae, IMimetillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mimetillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2093333;

    /// <inheritdoc />
    public virtual string GenusName => "Mimetillus";

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
