using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Rhinoplax;

/// <summary>
/// Abstract class for Rhinoplax (genus).
/// NCBI TaxId: 866440
/// </summary>
public abstract class Rhinoplax : Bucerotidae, IRhinoplax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoplax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866440;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoplax";

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
