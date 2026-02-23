using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Bagre;

/// <summary>
/// Abstract class for Bagre (genus).
/// NCBI TaxId: 243719
/// </summary>
public abstract class Bagre : Ariidae, IBagre
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagre";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243719;

    /// <inheritdoc />
    public virtual string GenusName => "Bagre";

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
