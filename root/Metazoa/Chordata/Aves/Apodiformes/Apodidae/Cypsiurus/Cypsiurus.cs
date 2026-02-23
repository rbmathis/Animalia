using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Cypsiurus;

/// <summary>
/// Abstract class for Cypsiurus (genus).
/// NCBI TaxId: 46497
/// </summary>
public abstract class Cypsiurus : Apodidae, ICypsiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cypsiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46497;

    /// <inheritdoc />
    public virtual string GenusName => "Cypsiurus";

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
