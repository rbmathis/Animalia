using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Niphonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Niphonidae.Niphon;

/// <summary>
/// Abstract class for Niphon (genus).
/// NCBI TaxId: 228253
/// </summary>
public abstract class Niphon : Niphonidae, INiphon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Niphon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228253;

    /// <inheritdoc />
    public virtual string GenusName => "Niphon";

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
