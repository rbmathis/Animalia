using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Thalassobathia;

/// <summary>
/// Abstract class for Thalassobathia (genus).
/// NCBI TaxId: 1263178
/// </summary>
public abstract class Thalassobathia : Ophidiidae, IThalassobathia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassobathia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263178;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassobathia";

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
