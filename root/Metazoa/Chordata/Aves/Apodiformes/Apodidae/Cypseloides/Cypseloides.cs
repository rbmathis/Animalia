using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Cypseloides;

/// <summary>
/// Abstract class for Cypseloides (genus).
/// NCBI TaxId: 46499
/// </summary>
public abstract class Cypseloides : Apodidae, ICypseloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cypseloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46499;

    /// <inheritdoc />
    public virtual string GenusName => "Cypseloides";

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
