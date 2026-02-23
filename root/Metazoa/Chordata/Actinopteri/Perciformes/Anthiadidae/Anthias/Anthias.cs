using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Anthias;

/// <summary>
/// Abstract class for Anthias (genus).
/// NCBI TaxId: 327820
/// </summary>
public abstract class Anthias : Anthiadidae, IAnthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327820;

    /// <inheritdoc />
    public virtual string GenusName => "Anthias";

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
