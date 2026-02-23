using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Alestes;

/// <summary>
/// Abstract class for Alestes (genus).
/// NCBI TaxId: 42483
/// </summary>
public abstract class Alestes : Alestidae, IAlestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42483;

    /// <inheritdoc />
    public virtual string GenusName => "Alestes";

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
