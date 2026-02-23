using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Apristurus;

/// <summary>
/// Abstract class for Apristurus (genus).
/// NCBI TaxId: 164744
/// </summary>
public abstract class Apristurus : Scyliorhinidae, IApristurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apristurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164744;

    /// <inheritdoc />
    public virtual string GenusName => "Apristurus";

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
