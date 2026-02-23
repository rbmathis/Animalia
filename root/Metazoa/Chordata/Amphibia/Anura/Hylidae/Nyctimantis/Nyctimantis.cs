using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Abstract class for Nyctimantis (genus).
/// NCBI TaxId: 318402
/// </summary>
public abstract class Nyctimantis : Hylidae, INyctimantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctimantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318402;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctimantis";

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
