using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Jubula;

/// <summary>
/// Abstract class for Jubula (genus).
/// NCBI TaxId: 2654007
/// </summary>
public abstract class Jubula : Strigidae, IJubula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jubula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2654007;

    /// <inheritdoc />
    public virtual string GenusName => "Jubula";

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
