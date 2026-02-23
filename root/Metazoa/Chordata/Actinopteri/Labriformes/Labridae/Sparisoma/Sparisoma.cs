using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Sparisoma;

/// <summary>
/// Abstract class for Sparisoma (genus).
/// NCBI TaxId: 51764
/// </summary>
public abstract class Sparisoma : Labridae, ISparisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sparisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51764;

    /// <inheritdoc />
    public virtual string GenusName => "Sparisoma";

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
