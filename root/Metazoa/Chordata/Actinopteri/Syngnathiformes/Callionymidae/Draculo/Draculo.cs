using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Draculo;

/// <summary>
/// Abstract class for Draculo (genus).
/// NCBI TaxId: 990979
/// </summary>
public abstract class Draculo : Callionymidae, IDraculo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Draculo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990979;

    /// <inheritdoc />
    public virtual string GenusName => "Draculo";

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
