using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Parastrellus;

/// <summary>
/// Abstract class for Parastrellus (genus).
/// NCBI TaxId: 712815
/// </summary>
public abstract class Parastrellus : Vespertilionidae, IParastrellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parastrellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 712815;

    /// <inheritdoc />
    public virtual string GenusName => "Parastrellus";

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
