using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hesperoptenus;

/// <summary>
/// Abstract class for Hesperoptenus (genus).
/// NCBI TaxId: 526819
/// </summary>
public abstract class Hesperoptenus : Vespertilionidae, IHesperoptenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperoptenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526819;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperoptenus";

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
