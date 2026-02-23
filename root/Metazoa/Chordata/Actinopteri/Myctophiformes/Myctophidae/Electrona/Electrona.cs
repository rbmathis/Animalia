using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Electrona;

/// <summary>
/// Abstract class for Electrona (genus).
/// NCBI TaxId: 68518
/// </summary>
public abstract class Electrona : Myctophidae, IElectrona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Electrona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68518;

    /// <inheritdoc />
    public virtual string GenusName => "Electrona";

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
