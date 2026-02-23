using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Attonitus;

/// <summary>
/// Abstract class for Attonitus (genus).
/// NCBI TaxId: 1463115
/// </summary>
public abstract class Attonitus : Stevardiidae, IAttonitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Attonitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463115;

    /// <inheritdoc />
    public virtual string GenusName => "Attonitus";

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
