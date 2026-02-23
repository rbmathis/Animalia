using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Fossa;

/// <summary>
/// Abstract class for Fossa (genus).
/// NCBI TaxId: 143319
/// </summary>
public abstract class Fossa : Eupleridae, IFossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143319;

    /// <inheritdoc />
    public virtual string GenusName => "Fossa";

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
