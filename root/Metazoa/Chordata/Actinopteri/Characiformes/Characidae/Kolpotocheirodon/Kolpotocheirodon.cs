using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Kolpotocheirodon;

/// <summary>
/// Abstract class for Kolpotocheirodon (genus).
/// NCBI TaxId: 930342
/// </summary>
public abstract class Kolpotocheirodon : Characidae, IKolpotocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kolpotocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930342;

    /// <inheritdoc />
    public virtual string GenusName => "Kolpotocheirodon";

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
