using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Monotocheirodon;

/// <summary>
/// Abstract class for Monotocheirodon (genus).
/// NCBI TaxId: 1463303
/// </summary>
public abstract class Monotocheirodon : Stevardiidae, IMonotocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monotocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463303;

    /// <inheritdoc />
    public virtual string GenusName => "Monotocheirodon";

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
