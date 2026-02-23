using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ariopsis;

/// <summary>
/// Abstract class for Ariopsis (genus).
/// NCBI TaxId: 243723
/// </summary>
public abstract class Ariopsis : Ariidae, IAriopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ariopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243723;

    /// <inheritdoc />
    public virtual string GenusName => "Ariopsis";

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
