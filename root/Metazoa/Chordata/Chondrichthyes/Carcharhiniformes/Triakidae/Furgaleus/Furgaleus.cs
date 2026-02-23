using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Furgaleus;

/// <summary>
/// Abstract class for Furgaleus (genus).
/// NCBI TaxId: 335036
/// </summary>
public abstract class Furgaleus : Triakidae, IFurgaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Furgaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335036;

    /// <inheritdoc />
    public virtual string GenusName => "Furgaleus";

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
