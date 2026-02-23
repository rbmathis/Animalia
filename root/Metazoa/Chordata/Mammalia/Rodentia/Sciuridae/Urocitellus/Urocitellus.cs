using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Urocitellus;

/// <summary>
/// Abstract class for Urocitellus (genus).
/// NCBI TaxId: 1141645
/// </summary>
public abstract class Urocitellus : Sciuridae, IUrocitellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocitellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1141645;

    /// <inheritdoc />
    public virtual string GenusName => "Urocitellus";

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
