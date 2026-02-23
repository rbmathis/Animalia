using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae.Chaunacops;

/// <summary>
/// Abstract class for Chaunacops (genus).
/// NCBI TaxId: 1197888
/// </summary>
public abstract class Chaunacops : Chaunacidae, IChaunacops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaunacops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1197888;

    /// <inheritdoc />
    public virtual string GenusName => "Chaunacops";

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
