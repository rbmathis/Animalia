using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Polylepion;

/// <summary>
/// Abstract class for Polylepion (genus).
/// NCBI TaxId: 998005
/// </summary>
public abstract class Polylepion : Labridae, IPolylepion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polylepion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 998005;

    /// <inheritdoc />
    public virtual string GenusName => "Polylepion";

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
