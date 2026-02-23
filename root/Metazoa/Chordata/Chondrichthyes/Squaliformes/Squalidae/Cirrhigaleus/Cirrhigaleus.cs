using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Cirrhigaleus;

/// <summary>
/// Abstract class for Cirrhigaleus (genus).
/// NCBI TaxId: 335023
/// </summary>
public abstract class Cirrhigaleus : Squalidae, ICirrhigaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhigaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335023;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhigaleus";

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
