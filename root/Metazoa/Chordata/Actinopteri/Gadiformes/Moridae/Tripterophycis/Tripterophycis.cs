using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Tripterophycis;

/// <summary>
/// Abstract class for Tripterophycis (genus).
/// NCBI TaxId: 1003991
/// </summary>
public abstract class Tripterophycis : Moridae, ITripterophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tripterophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003991;

    /// <inheritdoc />
    public virtual string GenusName => "Tripterophycis";

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
