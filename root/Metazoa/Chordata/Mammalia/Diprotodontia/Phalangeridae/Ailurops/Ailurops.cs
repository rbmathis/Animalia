using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Ailurops;

/// <summary>
/// Abstract class for Ailurops (genus).
/// NCBI TaxId: 165203
/// </summary>
public abstract class Ailurops : Phalangeridae, IAilurops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailurops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 165203;

    /// <inheritdoc />
    public virtual string GenusName => "Ailurops";

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
