using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Gephyrocharax;

/// <summary>
/// Abstract class for Gephyrocharax (genus).
/// NCBI TaxId: 42593
/// </summary>
public abstract class Gephyrocharax : Stevardiidae, IGephyrocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gephyrocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42593;

    /// <inheritdoc />
    public virtual string GenusName => "Gephyrocharax";

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
