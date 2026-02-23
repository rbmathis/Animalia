using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Ctenopoma;

/// <summary>
/// Abstract class for Ctenopoma (genus).
/// NCBI TaxId: 206119
/// </summary>
public abstract class Ctenopoma : Anabantidae, ICtenopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206119;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenopoma";

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
