using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aeronautes;

/// <summary>
/// Abstract class for Aeronautes (genus).
/// NCBI TaxId: 190673
/// </summary>
public abstract class Aeronautes : Apodidae, IAeronautes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aeronautes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190673;

    /// <inheritdoc />
    public virtual string GenusName => "Aeronautes";

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
