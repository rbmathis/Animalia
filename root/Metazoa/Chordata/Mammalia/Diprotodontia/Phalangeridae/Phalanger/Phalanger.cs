using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Phalanger;

/// <summary>
/// Abstract class for Phalanger (genus).
/// NCBI TaxId: 38622
/// </summary>
public abstract class Phalanger : Phalangeridae, IPhalanger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalanger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38622;

    /// <inheritdoc />
    public virtual string GenusName => "Phalanger";

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
