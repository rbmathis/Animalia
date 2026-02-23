using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Apus;

/// <summary>
/// Abstract class for Apus (genus).
/// NCBI TaxId: 8894
/// </summary>
public abstract class Apus : Apodidae, IApus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8894;

    /// <inheritdoc />
    public virtual string GenusName => "Apus";

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
