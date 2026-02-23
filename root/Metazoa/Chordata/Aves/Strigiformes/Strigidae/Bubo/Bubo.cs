using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

/// <summary>
/// Abstract class for Bubo (genus).
/// NCBI TaxId: 30460
/// </summary>
public abstract class Bubo : Strigidae, IBubo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bubo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30460;

    /// <inheritdoc />
    public virtual string GenusName => "Bubo";

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
