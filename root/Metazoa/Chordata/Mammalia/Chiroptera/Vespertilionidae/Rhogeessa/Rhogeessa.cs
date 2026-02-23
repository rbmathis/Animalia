using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhogeessa;

/// <summary>
/// Abstract class for Rhogeessa (genus).
/// NCBI TaxId: 153294
/// </summary>
public abstract class Rhogeessa : Vespertilionidae, IRhogeessa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhogeessa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153294;

    /// <inheritdoc />
    public virtual string GenusName => "Rhogeessa";

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
