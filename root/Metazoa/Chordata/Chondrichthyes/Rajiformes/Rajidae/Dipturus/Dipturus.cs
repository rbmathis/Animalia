using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Dipturus;

/// <summary>
/// Abstract class for Dipturus (genus).
/// NCBI TaxId: 117858
/// </summary>
public abstract class Dipturus : Rajidae, IDipturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117858;

    /// <inheritdoc />
    public virtual string GenusName => "Dipturus";

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
