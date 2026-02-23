using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Crenidens;

/// <summary>
/// Abstract class for Crenidens (genus).
/// NCBI TaxId: 119707
/// </summary>
public abstract class Crenidens : Sparidae, ICrenidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crenidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119707;

    /// <inheritdoc />
    public virtual string GenusName => "Crenidens";

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
