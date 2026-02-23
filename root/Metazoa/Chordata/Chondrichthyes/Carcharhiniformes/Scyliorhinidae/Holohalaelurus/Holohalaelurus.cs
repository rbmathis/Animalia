using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Holohalaelurus;

/// <summary>
/// Abstract class for Holohalaelurus (genus).
/// NCBI TaxId: 990981
/// </summary>
public abstract class Holohalaelurus : Scyliorhinidae, IHolohalaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holohalaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990981;

    /// <inheritdoc />
    public virtual string GenusName => "Holohalaelurus";

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
