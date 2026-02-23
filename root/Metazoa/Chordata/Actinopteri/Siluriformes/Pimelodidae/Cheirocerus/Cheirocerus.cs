using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Cheirocerus;

/// <summary>
/// Abstract class for Cheirocerus (genus).
/// NCBI TaxId: 337765
/// </summary>
public abstract class Cheirocerus : Pimelodidae, ICheirocerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheirocerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337765;

    /// <inheritdoc />
    public virtual string GenusName => "Cheirocerus";

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
