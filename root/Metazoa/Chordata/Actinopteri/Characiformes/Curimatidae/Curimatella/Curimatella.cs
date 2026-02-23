using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimatella;

/// <summary>
/// Abstract class for Curimatella (genus).
/// NCBI TaxId: 143034
/// </summary>
public abstract class Curimatella : Curimatidae, ICurimatella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Curimatella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143034;

    /// <inheritdoc />
    public virtual string GenusName => "Curimatella";

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
