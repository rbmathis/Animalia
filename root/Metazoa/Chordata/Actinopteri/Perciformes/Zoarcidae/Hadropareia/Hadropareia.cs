using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Hadropareia;

/// <summary>
/// Abstract class for Hadropareia (genus).
/// NCBI TaxId: 435300
/// </summary>
public abstract class Hadropareia : Zoarcidae, IHadropareia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hadropareia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435300;

    /// <inheritdoc />
    public virtual string GenusName => "Hadropareia";

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
