using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Megalopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Megalopidae.Megalops;

/// <summary>
/// Abstract class for Megalops (genus).
/// NCBI TaxId: 7931
/// </summary>
public abstract class Megalops : Megalopidae, IMegalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7931;

    /// <inheritdoc />
    public virtual string GenusName => "Megalops";

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
