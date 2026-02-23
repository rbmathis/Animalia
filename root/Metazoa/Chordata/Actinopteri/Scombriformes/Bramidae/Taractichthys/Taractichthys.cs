using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Taractichthys;

/// <summary>
/// Abstract class for Taractichthys (genus).
/// NCBI TaxId: 425392
/// </summary>
public abstract class Taractichthys : Bramidae, ITaractichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taractichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425392;

    /// <inheritdoc />
    public virtual string GenusName => "Taractichthys";

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
