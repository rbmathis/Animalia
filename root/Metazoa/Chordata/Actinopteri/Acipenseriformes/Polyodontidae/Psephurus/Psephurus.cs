using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae.Psephurus;

/// <summary>
/// Abstract class for Psephurus (genus).
/// NCBI TaxId: 61975
/// </summary>
public abstract class Psephurus : Polyodontidae, IPsephurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psephurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61975;

    /// <inheritdoc />
    public virtual string GenusName => "Psephurus";

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
