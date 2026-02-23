using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Jeboehlkia;

/// <summary>
/// Abstract class for Jeboehlkia (genus).
/// NCBI TaxId: 2893511
/// </summary>
public abstract class Jeboehlkia : Serranidae, IJeboehlkia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jeboehlkia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893511;

    /// <inheritdoc />
    public virtual string GenusName => "Jeboehlkia";

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
