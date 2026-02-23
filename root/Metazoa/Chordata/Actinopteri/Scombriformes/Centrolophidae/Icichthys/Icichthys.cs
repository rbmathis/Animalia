using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Icichthys;

/// <summary>
/// Abstract class for Icichthys (genus).
/// NCBI TaxId: 302050
/// </summary>
public abstract class Icichthys : Centrolophidae, IIcichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Icichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302050;

    /// <inheritdoc />
    public virtual string GenusName => "Icichthys";

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
