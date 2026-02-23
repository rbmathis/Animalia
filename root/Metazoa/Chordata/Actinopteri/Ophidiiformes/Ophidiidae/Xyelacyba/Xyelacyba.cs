using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Xyelacyba;

/// <summary>
/// Abstract class for Xyelacyba (genus).
/// NCBI TaxId: 1812885
/// </summary>
public abstract class Xyelacyba : Ophidiidae, IXyelacyba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xyelacyba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812885;

    /// <inheritdoc />
    public virtual string GenusName => "Xyelacyba";

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
