using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Wyulda;

/// <summary>
/// Abstract class for Wyulda (genus).
/// NCBI TaxId: 175812
/// </summary>
public abstract class Wyulda : Phalangeridae, IWyulda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wyulda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175812;

    /// <inheritdoc />
    public virtual string GenusName => "Wyulda";

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
