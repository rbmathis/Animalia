using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Davidijordania;

/// <summary>
/// Abstract class for Davidijordania (genus).
/// NCBI TaxId: 932714
/// </summary>
public abstract class Davidijordania : Zoarcidae, IDavidijordania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Davidijordania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 932714;

    /// <inheritdoc />
    public virtual string GenusName => "Davidijordania";

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
