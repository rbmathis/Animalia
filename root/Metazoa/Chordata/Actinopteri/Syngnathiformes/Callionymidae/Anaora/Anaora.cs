using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Anaora;

/// <summary>
/// Abstract class for Anaora (genus).
/// NCBI TaxId: 1972147
/// </summary>
public abstract class Anaora : Callionymidae, IAnaora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anaora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1972147;

    /// <inheritdoc />
    public virtual string GenusName => "Anaora";

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
