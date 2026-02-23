using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Microctenopoma;

/// <summary>
/// Abstract class for Microctenopoma (genus).
/// NCBI TaxId: 313165
/// </summary>
public abstract class Microctenopoma : Anabantidae, IMicroctenopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microctenopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313165;

    /// <inheritdoc />
    public virtual string GenusName => "Microctenopoma";

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
