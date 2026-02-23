using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Hemisalanx;

/// <summary>
/// Abstract class for Hemisalanx (genus).
/// NCBI TaxId: 240823
/// </summary>
public abstract class Hemisalanx : Salangidae, IHemisalanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemisalanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240823;

    /// <inheritdoc />
    public virtual string GenusName => "Hemisalanx";

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
