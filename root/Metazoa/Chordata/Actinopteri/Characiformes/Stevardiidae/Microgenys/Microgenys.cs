using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Microgenys;

/// <summary>
/// Abstract class for Microgenys (genus).
/// NCBI TaxId: 3290087
/// </summary>
public abstract class Microgenys : Stevardiidae, IMicrogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3290087;

    /// <inheritdoc />
    public virtual string GenusName => "Microgenys";

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
