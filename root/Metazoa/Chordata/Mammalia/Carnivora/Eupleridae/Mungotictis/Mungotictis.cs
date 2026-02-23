using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Mungotictis;

/// <summary>
/// Abstract class for Mungotictis (genus).
/// NCBI TaxId: 205648
/// </summary>
public abstract class Mungotictis : Eupleridae, IMungotictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mungotictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205648;

    /// <inheritdoc />
    public virtual string GenusName => "Mungotictis";

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
