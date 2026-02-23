using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Rhinopomastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Rhinopomastidae.Rhinopomastus;

/// <summary>
/// Abstract class for Rhinopomastus (genus).
/// NCBI TaxId: 113114
/// </summary>
public abstract class Rhinopomastus : Rhinopomastidae, IRhinopomastus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinopomastus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113114;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinopomastus";

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
