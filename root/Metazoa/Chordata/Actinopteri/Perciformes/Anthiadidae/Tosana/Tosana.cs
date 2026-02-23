using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosana;

/// <summary>
/// Abstract class for Tosana (genus).
/// NCBI TaxId: 428437
/// </summary>
public abstract class Tosana : Anthiadidae, ITosana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tosana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428437;

    /// <inheritdoc />
    public virtual string GenusName => "Tosana";

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
