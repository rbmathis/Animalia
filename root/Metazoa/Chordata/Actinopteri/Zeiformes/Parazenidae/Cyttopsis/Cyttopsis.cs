using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Cyttopsis;

/// <summary>
/// Abstract class for Cyttopsis (genus).
/// NCBI TaxId: 1176754
/// </summary>
public abstract class Cyttopsis : Parazenidae, ICyttopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyttopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1176754;

    /// <inheritdoc />
    public virtual string GenusName => "Cyttopsis";

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
