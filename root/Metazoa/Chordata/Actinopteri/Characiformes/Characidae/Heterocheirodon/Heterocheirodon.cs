using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Heterocheirodon;

/// <summary>
/// Abstract class for Heterocheirodon (genus).
/// NCBI TaxId: 930329
/// </summary>
public abstract class Heterocheirodon : Characidae, IHeterocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930329;

    /// <inheritdoc />
    public virtual string GenusName => "Heterocheirodon";

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
