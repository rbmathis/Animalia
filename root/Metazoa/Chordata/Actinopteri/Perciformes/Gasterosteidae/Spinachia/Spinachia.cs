using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Spinachia;

/// <summary>
/// Abstract class for Spinachia (genus).
/// NCBI TaxId: 206125
/// </summary>
public abstract class Spinachia : Gasterosteidae, ISpinachia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinachia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206125;

    /// <inheritdoc />
    public virtual string GenusName => "Spinachia";

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
