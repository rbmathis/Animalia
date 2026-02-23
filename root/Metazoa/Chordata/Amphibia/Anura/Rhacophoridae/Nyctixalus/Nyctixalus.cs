using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Nyctixalus;

/// <summary>
/// Abstract class for Nyctixalus (genus).
/// NCBI TaxId: 126587
/// </summary>
public abstract class Nyctixalus : Rhacophoridae, INyctixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126587;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctixalus";

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
