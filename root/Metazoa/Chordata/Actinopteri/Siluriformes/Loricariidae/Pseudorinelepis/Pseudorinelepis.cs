using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudorinelepis;

/// <summary>
/// Abstract class for Pseudorinelepis (genus).
/// NCBI TaxId: 338095
/// </summary>
public abstract class Pseudorinelepis : Loricariidae, IPseudorinelepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorinelepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338095;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorinelepis";

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
