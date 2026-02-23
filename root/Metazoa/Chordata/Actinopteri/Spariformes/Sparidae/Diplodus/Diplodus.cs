using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Diplodus;

/// <summary>
/// Abstract class for Diplodus (genus).
/// NCBI TaxId: 38940
/// </summary>
public abstract class Diplodus : Sparidae, IDiplodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38940;

    /// <inheritdoc />
    public virtual string GenusName => "Diplodus";

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
