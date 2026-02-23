using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Creagrutus;

/// <summary>
/// Abstract class for Creagrutus (genus).
/// NCBI TaxId: 304253
/// </summary>
public abstract class Creagrutus : Stevardiidae, ICreagrutus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creagrutus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304253;

    /// <inheritdoc />
    public virtual string GenusName => "Creagrutus";

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
