using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Carnegiella;

/// <summary>
/// Abstract class for Carnegiella (genus).
/// NCBI TaxId: 42632
/// </summary>
public abstract class Carnegiella : Gasteropelecidae, ICarnegiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carnegiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42632;

    /// <inheritdoc />
    public virtual string GenusName => "Carnegiella";

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
