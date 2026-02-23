using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Morphnarchus;

/// <summary>
/// Abstract class for Morphnarchus (genus).
/// NCBI TaxId: 2869453
/// </summary>
public abstract class Morphnarchus : Accipitridae, IMorphnarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morphnarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2869453;

    /// <inheritdoc />
    public virtual string GenusName => "Morphnarchus";

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
