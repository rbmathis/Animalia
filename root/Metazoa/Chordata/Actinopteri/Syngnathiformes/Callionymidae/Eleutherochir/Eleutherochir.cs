using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Eleutherochir;

/// <summary>
/// Abstract class for Eleutherochir (genus).
/// NCBI TaxId: 1503352
/// </summary>
public abstract class Eleutherochir : Callionymidae, IEleutherochir
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleutherochir";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1503352;

    /// <inheritdoc />
    public virtual string GenusName => "Eleutherochir";

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
